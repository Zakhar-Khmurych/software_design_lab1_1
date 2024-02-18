namespace Commands
{
    public abstract class Command : ICommand
    {
        protected abstract string Module { get; }
        protected abstract string Action { get; }

        public bool CanHandle(string command)
        {
            var split = command.Split(' ');
            if (Module != split[0])
            {
                return false;
            }

            if (Action != split[1])
            {
                return false;
            }

            return true;
        }

        public void Execute(string input)
        {
            var inputParts = input.Split(' ');
            var args = new string[inputParts.Length - 2];
            for (int i = 2; i < inputParts.Length; i++)
            {
                args[i - 2] = inputParts[i];
            }
            ExecuteInternal(args);
        }



        protected abstract void ExecuteInternal(string[] args);
    }
}