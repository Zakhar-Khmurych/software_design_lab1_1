using System;
using System.Linq;

namespace StepByStep
{
    public interface ICommand
    {
        bool CanHandle(string command);
        void Execute(string input);
    }
    
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
            ExecuteInternal(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Skip(2).ToArray());
        }

        protected abstract void ExecuteInternal(string[] args);
    }
}