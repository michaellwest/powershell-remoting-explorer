winrm quickconfig -q
winrm set winrm/config/service/Auth '@{Basic=\"true\"}'
winrm set winrm/config/service '@{AllowUnencrypted=\"true\"}'
winrm set winrm/config/winrs '@{MaxMemoryPerShellMB=\"1024\"}'

net user /add PSRemotingUser P@ssw0rd1!
net localgroup Administrators PSRemotingUser /add

while ($true) {
    Test-Connection -ComputerName 127.0.0.1 > $null
    Start-Sleep -Seconds 1
}