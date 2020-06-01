using Command_Line_Snippets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Line_Snippets.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Test", Line = "tfest", Platform = "testftt" },
                new Command { Id = 1, HowTo = "Tests", Line = "tesst", Platform = "tessttt" },
                new Command { Id = 2, HowTo = "Tests", Line = "tesst", Platform = "tessttt" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Test", Line = "test", Platform = "testtt" };
        }
    }
}