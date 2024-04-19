# PubImport
Easily import `PublishSettings` files from the terminal.


## Installation
```bash
dotnet tool install -g PubImport
```

## Usage
```bash
# While inside the project's directory
dotnet pubimport <path-to-publish-settings-file>

# Alternatively, you can specify the project's directory with the -p flag
dotnet pubimport -p <path-to-project-directory> <path-to-publish-settings-file>
```