using PSRemotingExplorer.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;

namespace PSRemotingExplorer
{
    public class MachineManager : IManageMachines
    {
        public string IpAddress { get; private set; } = "127.0.0.1";

        public int Port { get; private set; } = 5985;

        public AuthenticationMechanism Authentication { get; private set; } = AuthenticationMechanism.Default;

        private readonly string username;

        private readonly SecureString password;

        private Runspace _Runspace;

        private object _Session;

        public MachineManager(string ipAddress, int port, string username, SecureString password, AuthenticationMechanism authentication)
        {
            this.IpAddress = ipAddress;
            this.Port = port;
            this.Authentication = authentication;

            this.username = username;
            this.password = password;
        }

        private void ThrowOnError(PowerShell powershell, string attemptedScriptBlock)
        {
            ThrowOnError(powershell, attemptedScriptBlock, IpAddress);
        }

        private static void ThrowOnError(PowerShell powershell, string attemptedScriptBlock, string ipAddress)
        {
            if (powershell.Streams.Error.Count > 0)
            {
                var errorString = string.Join(
                    Environment.NewLine,
                    powershell.Streams.Error.Select(
                        _ =>
                        (_.ErrorDetails == null ? null : _.ErrorDetails.ToString() + " at " + _.ScriptStackTrace)
                        ?? (_.Exception == null ? "Naos.WinRM: No error message available" : _.Exception.ToString() + " at " + _.ScriptStackTrace)));
                throw new RemoteExecutionException(
                    "Failed to run script (" + attemptedScriptBlock + ") on " + ipAddress + " got errors: "
                    + errorString);
            }
        }

        private static List<PSObject> RunLocalCommand(Runspace runspace, Command arbitraryCommand)
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.Runspace = runspace;

                powershell.Commands.AddCommand(arbitraryCommand);
                powershell.Streams.Progress.DataAdded += (sender, eventargs) => {
                    PSDataCollection<ProgressRecord> progressRecords = (PSDataCollection<ProgressRecord>)sender;
                    Console.WriteLine("Progress is {0} percent complete", progressRecords[eventargs.Index].PercentComplete);
                };

                var output = powershell.Invoke();

                ThrowOnError(powershell, arbitraryCommand.CommandText, "localhost");

                var ret = output.ToList();
                return ret;
            }
        }

        public void EnterSession()
        {
            _Runspace = RunspaceFactory.CreateRunspace();
            _Runspace.Open();

            var powershellCredentials = new PSCredential(this.username, this.password);

            var sessionOptionsCommand = new Command("New-PSSessionOption");
            sessionOptionsCommand.Parameters.Add("OperationTimeout", 0);
            sessionOptionsCommand.Parameters.Add("IdleTimeout", TimeSpan.FromMinutes(20).TotalMilliseconds);
            var sessionOptionsObject = RunLocalCommand(_Runspace, sessionOptionsCommand).Single().BaseObject;

            var sessionCommand = new Command("New-PSSession");
            sessionCommand.Parameters.Add("ComputerName", IpAddress);
            sessionCommand.Parameters.Add("Port", Port);
            sessionCommand.Parameters.Add("Authentication", Authentication);
            sessionCommand.Parameters.Add("Credential", powershellCredentials);
            sessionCommand.Parameters.Add("SessionOption", sessionOptionsObject);
            var sessionObject = RunLocalCommand(_Runspace, sessionCommand).Single().BaseObject;
            _Session = sessionObject;
        }

        public void ExitSession()
        {
            _Runspace.Close();
            _Runspace.Dispose();

            _Session = null;
        }

        public void CopyFileFromSession(string filePathOnTargetMachine, string filePathOnLocalMachine)
        {
            var sessionCommand = new Command("Copy-Item");
            sessionCommand.Parameters.Add("Path", filePathOnTargetMachine);
            sessionCommand.Parameters.Add("Destination", filePathOnLocalMachine);
            sessionCommand.Parameters.Add("FromSession", _Session);
            RunLocalCommand(_Runspace, sessionCommand);
        }

        public void CopyFileToSession(string filePathOnTargetMachine, string filePathOnLocalMachine)
        {
            var sessionCommand = new Command("Copy-Item");
            sessionCommand.Parameters.Add("Path", filePathOnTargetMachine);
            sessionCommand.Parameters.Add("Destination", filePathOnLocalMachine);
            sessionCommand.Parameters.Add("ToSession", _Session);
            RunLocalCommand(_Runspace, sessionCommand);
        }

        private List<PSObject> RunScriptUsingSession(
            string scriptBlock,
            ICollection<object> scriptBlockParameters,
            Runspace runspace,
            object sessionObject)
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.Runspace = runspace;

                Collection<PSObject> output;

                // session will implicitly assume remote - if null then localhost...
                if (sessionObject != null)
                {
                    var variableNameArgs = "scriptBlockArgs";
                    var variableNameSession = "invokeCommandSession";
                    powershell.Runspace.SessionStateProxy.SetVariable(variableNameSession, sessionObject);

                    var argsAddIn = string.Empty;
                    if (scriptBlockParameters != null && scriptBlockParameters.Count > 0)
                    {
                        powershell.Runspace.SessionStateProxy.SetVariable(
                            variableNameArgs,
                            scriptBlockParameters.ToArray());
                        argsAddIn = " -ArgumentList $" + variableNameArgs;
                    }

                    var fullScript = "$sc = " + scriptBlock + Environment.NewLine + "Invoke-Command -Session $"
                                     + variableNameSession + argsAddIn + " -ScriptBlock $sc";

                    powershell.AddScript(fullScript);
                    output = powershell.Invoke();
                }
                else
                {
                    var fullScript = "$sc = " + scriptBlock + Environment.NewLine + "Invoke-Command -ScriptBlock $sc";

                    powershell.AddScript(fullScript);
                    foreach (var scriptBlockParameter in scriptBlockParameters ?? new List<object>())
                    {
                        powershell.AddArgument(scriptBlockParameter);
                    }

                    output = powershell.Invoke(scriptBlockParameters);
                }

                ThrowOnError(powershell, scriptBlock);

                return output.ToList();
            }
        }

        public ICollection<PSObject> RunScript(string scriptBlock, ICollection<object> scriptBlockParameters = null)
        {
            return RunScriptUsingSession(scriptBlock, scriptBlockParameters, _Runspace, _Session);
        }

        public void RemoveFileFromSession(string filePathOnTargetMachine)
        {
            var script = "{ param($path) Remove-Item -Path $path}";
            RunScriptUsingSession(script, new[] { filePathOnTargetMachine }, _Runspace, _Session);
        }
    }
}
