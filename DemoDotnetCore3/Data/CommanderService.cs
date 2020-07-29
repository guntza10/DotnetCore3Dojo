using System;
using System.Collections.Generic;
using DemoDotnetCore3.Models;
using MongoDB.Driver;

namespace DemoDotnetCore3.Data
{
    public class CommanderService : ICommanderService
    {
        private readonly IMongoCollection<Command> _CommandCollection;
        public CommanderService(IDbConfig settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DbName);
            _CommandCollection = database.GetCollection<Command>(settings.Command);
        }

        public List<Command> GetAllCommand()
        {
            var allCommand = _CommandCollection.Find(it => true).ToList();
            return allCommand;
        }

        public Command GetCommandById(string id)
        {
            var command = _CommandCollection.Find(it => it.Id == id).FirstOrDefault();
            return command;
        }

        public void AddCommand(Command commandData)
        {
            commandData.Id = Guid.NewGuid().ToString();
            _CommandCollection.InsertOne(commandData);
        }
    }
}