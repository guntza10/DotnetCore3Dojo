using System.Collections.Generic;
using DemoDotnetCore3.Models;

namespace DemoDotnetCore3.Data
{
    public interface ICommanderService
    {
        List<Command> GetAllCommand();
        Command GetCommandById(string id);
        void AddCommand(Command data);
    }
}