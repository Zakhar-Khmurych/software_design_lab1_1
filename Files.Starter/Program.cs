using System;
using Employee.Setup;
using Employees.Domain;


namespace Files.Starter
{

    var commandFactory = new CommandFactory(new FileRegistry());
    var commands = commandFactory.GetAllCommands();
    while (true)
    {
        var input = Console.ReadLine();
        if (!TryHandle(input))
        {
            Console.WriteLine($"Unknown command '{input}', please try again");
        }
    }

    bool TryHandle(string input)
    {
        foreach (var command in commands)
        {
            if (command.CanHandle(input))
            {
                command.Execute(input);
                return true;
            }
        }

        return false;
    } 
}