
using System.Collections.Generic;


namespace StepByStep
{
    public interface ICommandFactory
    {
        List<ICommand> GetAllCommands();
    } 
    
    public class Add : Command
    {
        private readonly IFileRegistry fileRegistry;

        public Add(IFileRegistry fileRegistry)
        {
            this.fileRegistry = fileRegistry;
        }

        protected override string Module => "Add";
        protected override string Action => "Action";

        protected override void ExecuteInternal(string[] args)
        {
            // Implement Add command logic
        }
    }

    public class Remove : Command
    {
        private readonly IFileRegistry fileRegistry;

        public Remove(IFileRegistry fileRegistry)
        {
            this.fileRegistry = fileRegistry;
        }

        protected override string Module => "Remove";
        protected override string Action => "Action";

        protected override void ExecuteInternal(string[] args)
        {
            // Implement Remove command logic
        }
    }

    public class ListCommand : Command
    {
        private readonly IFileRegistry fileRegistry;

        public ListCommand(IFileRegistry fileRegistry)
        {
            this.fileRegistry = fileRegistry;
        }

        protected override string Module => "List";
        protected override string Action => "Action";

        protected override void ExecuteInternal(string[] args)
        {
            // Implement List command logic
        }
    }
    
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
                new Add(fileRegistry),
                new Remove(fileRegistry),
              //  new List(fileRegistry),
            };
        }
    }
    
}