# PowerShell Remoting Explorer

## Getting Started

The following steps will help you get started working against a demo Docker container. If you have other servers setup such as on a domain then skip ahead.

* Run a neverending Windows container : `docker-compose up -d`
* Run the PSRemotingExplorer and connect.

Connecting to the Docker container using the default credentials provided.

![image](https://user-images.githubusercontent.com/933163/74116321-ab47f580-4b78-11ea-8d6d-04a2a90a5315.png)

Manage existing files on the server.

![image](https://user-images.githubusercontent.com/933163/74116507-6a9cac00-4b79-11ea-8bf6-3dc09d3b4dde.png)

**Note:** The default port used for Winrm is 5985 and was changed to 55985 for Docker containers.

## Saving Settings

The settings in the interface are saved per user in the following directory: `C:\Users\{CURRENT_USER}\AppData\Local\PSRemotingExplorer`