using System.Collections.Generic;
using DemoDotnetCore3.Models;

namespace DemoDotnetCore3.Data
{
    public interface ICommanderRepo
    {
        List<Command> GetAllCommand();
        Command GetCommandById(string id);
        void AddCommand(Command data);
    }
}