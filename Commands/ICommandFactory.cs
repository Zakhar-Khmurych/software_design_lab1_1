using System.Collections.Generic;

namespace Commands
{
    public interface ICommandFactory
    {
        List<ICommand> GetAllCommands();
    }
}