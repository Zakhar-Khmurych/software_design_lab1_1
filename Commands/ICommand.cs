namespace Commands
{
    public interface ICommand
    {
        bool CanHandle(string command);
        void Execute(string input);
    }
}