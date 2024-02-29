using System;

namespace StepByStep
{
    public class ConsoleReader
    {
        private string Command; //extract command system from actual commands, like in employees
        public void ReadConsole()
        {
            Command = Console.ReadLine();
            FileActions_old fileAction = new FileActions_old();
            string[] divide_input = Command.Split(' ');
            if (divide_input[0].ToLower() == "add")
            {
                fileAction.AddFile(divide_input[1]);
            }
            if (divide_input[0].ToLower() == "remove")
            {
                fileAction.RemoveFile(divide_input[1]);
            }
            if (divide_input[0].ToLower() == "list")
            {
                fileAction.ListFiles();
            }
            
        }
    }
}