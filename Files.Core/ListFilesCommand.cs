namespace Files.Starter;

using Files.Domain;

public class ListFileCommand : Command
{
    protected override string Module => "file";

    protected override string Action => "list";

    private readonly IFileRegistry registry;

    public ListFileCommand(IFileRegistry registry)
    {
        this.registry = registry;
    }

    protected override void ExecuteInternal(string[] args)
    {
        var counter = 1;
        foreach (var file in registry.GetAll())
        {
            Console.WriteLine($"{counter++}.\t{file.Name}");
        }
    }
}