namespace Files.Starter;

using Files.Domain;

public class RemoveFileCommand : Command
{
    protected override string Module => "file";

    protected override string Action => "remove";

    private readonly IFileRegistry registry;

    public RemoveFileCommand(IFileRegistry registry)
    {
        this.registry = registry;
    }

    protected override void ExecuteInternal(string[] args)
    {
        var name = args[0];
        if (registry.GetAll().All(file => file.Name != name))
        {
            Console.WriteLine("No such file, can not remove");
            return;
        }

        registry.Remove(name);
        Console.WriteLine($"File {name} removed!");
    }
}