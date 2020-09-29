using System.Collections.Generic;
using Commander.Modeles;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
            new Command{Id = 0, HowTo = "Boil an egg1", Line = "Boil Water", Platform = "kettle and pan"},
            new Command{Id = 1, HowTo = "Boil an egg2", Line = "Boil Water", Platform = "kettle and pan"},
            new Command{Id = 2, HowTo = "Boil an egg3", Line = "Boil Water", Platform = "kettle and pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Boial an egg", Line = "Boil Water", Platform = "kettle and pan"};
        }
    }
}