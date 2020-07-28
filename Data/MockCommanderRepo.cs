using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{

    public class MockCommanderRepo : ICommanderRepo

    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                 new Command {Id= 0, HowTo = "boil egg", Line = "Boil Water", Platform = "Kettle and Pan"},
                 new Command {Id= 1, HowTo = "cut egg", Line = "Get knife", Platform = "Knife Sharping"},
                 new Command {Id= 2, HowTo = "make cup tea", Line = "Boil tea", Platform = "Kettle and Tea"}

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id= 0, HowTo = "boil egg", Line = "Boil Water", Platform = "Kettle and Pan"};
        }
    }
}