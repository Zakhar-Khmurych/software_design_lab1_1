using System;
namespace FromScratch
{
    public class ConsoleReader
    {
        private string Command;
        public void ReadConsole()
        {
            Command = Console.ReadLine();
        }
    }
}