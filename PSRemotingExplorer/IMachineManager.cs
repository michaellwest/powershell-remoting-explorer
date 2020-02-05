using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace PSRemotingExplorer
{
    public interface IManageMachines
    {
        string IpAddress { get; }

        int Port { get; }

        AuthenticationMechanism Authentication { get; }

        void EnterSession();
        void ExitSession();

        void CopyFileFromSession(string filePathOnTargetMachine, string filePathOnLocalMachine);

        void CopyFileToSession(string filePathOnTargetMachine, string filePathOnLocalMachine);

        void RemoveFileFromSession(string filePathOnTargetMachine);

        ICollection<PSObject> RunScript(string scriptBlock, ICollection<object> scriptBlockParameters = null);
    }
}