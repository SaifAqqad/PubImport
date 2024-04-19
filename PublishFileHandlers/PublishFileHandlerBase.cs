namespace PubImport.PublishFileHandlers;

public abstract class PublishFileHandlerBase
{
    public abstract string FileType { get; }

    /// <summary>
    /// </summary>
    /// <param name="publishFile"></param>
    /// <param name="projectFile"></param>
    /// <returns></returns>
    public abstract PublishProfile Import(FileInfo publishFile, FileInfo? projectFile = null);
}