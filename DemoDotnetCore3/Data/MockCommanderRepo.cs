using System;
using System.Collections.Generic;
using DemoDotnetCore3.Models;
using MongoDB.Driver;

namespace DemoDotnetCore3.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private IMongoCollection<Command> CommandCollection { get; set; }
        public MockCommanderRepo()
        {
            var client = new MongoClient("mongodb+srv://admin:admin1234@tomorrow.0cukz.gcp.mongodb.net/<dbname>?retryWrites=true&w=majority");
            var database = client.GetDatabase("DemoDotnetCore3");
            CommandCollection = database.GetCollection<Command>("Command");
        }

        public List<Command> GetAllCommand()
        {
            var allCommand = CommandCollection.Find(it => true).ToList();
            return allCommand;
        }

        public Command GetCommandById(string id)
        {
            var command = CommandCollection.Find(it => it.Id == id).FirstOrDefault();
            return command;
        }

        public void AddCommand(Command commandData)
        {
            commandData.Id = Guid.NewGuid().ToString();
            CommandCollection.InsertOne(commandData);
        }
    }
}