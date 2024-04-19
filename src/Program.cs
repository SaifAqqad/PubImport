using System.CommandLine;

var projectOption = new Option<FileInfo?>(
    name: "--project",
    description: "The file to read and display on the console."
);

projectOption.AddAlias("-p");

var importCommand = new RootCommand("Sample app for System.CommandLine");
importCommand.AddAlias("import");

var publishFileArg = new Argument<FileInfo?>();
importCommand.AddArgument(publishFileArg);
importCommand.AddOption(projectOption);

importCommand.SetHandler(((publishFile, projectFile) => null!),publishFileArg, projectOption);

return await importCommand.InvokeAsync(args);