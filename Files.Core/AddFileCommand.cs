namespace Files.Starter;

using Files.Domain;

public class AddFileCommand : Command
{
    protected override string Module => "file";

    protected override string Action => "add";

    private readonly IFileRegistry registry;

    public AddFileCommand(IFileRegistry registry)
    {
        this.registry = registry;
    }

    protected override void ExecuteInternal(string[] args)
    {
        var name = args[0];
        registry.Add(name);
        Console.WriteLine($"File {name} added!");
    }

}