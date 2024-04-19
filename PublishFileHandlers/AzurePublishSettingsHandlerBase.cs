namespace PubImport.PublishFileHandlers;

public class AzurePublishSettingsHandlerBase : PublishFileHandlerBase
{
    public override string FileType => "PublishSettings";

    public override PublishProfile Import(FileInfo publishFile, FileInfo? projectFile = null)
    {
        throw new NotImplementedException();
    }
}