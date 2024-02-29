namespace Files.Starter
{
    using Files.Domain;
    using Files.Starter;

    public class CommandFactory : ICommandFactory
    {
        private readonly IFileRegistry fileRegistry;

        public CommandFactory(IFileRegistry fileRegistry)
        {
            this.fileRegistry = fileRegistry;
        }

        public List<ICommand> GetAllCommands()
        {
            return new List<ICommand>()
            {
                new AddFileCommand(employeeRegistry),
                new RemoveFileCommand(employeeRegistry),
                new ListFileCommand(employeeRegistry),
            };
        }
    }
}