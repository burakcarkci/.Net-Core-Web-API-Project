using Command_Line_Snippets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command_Line_Snippets.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}