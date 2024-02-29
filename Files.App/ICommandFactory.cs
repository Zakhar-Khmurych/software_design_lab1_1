namespace Files.App
{
    public interface ICommandFactory
    {
        List<ICommand> GetAllCommands();
    }
}