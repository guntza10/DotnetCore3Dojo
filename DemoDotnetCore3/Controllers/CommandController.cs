using System;
using System.Collections.Generic;
using DemoDotnetCore3.Data;
using DemoDotnetCore3.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace DemoDotnetCore3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Command>> GetAllCommand()
        {
            var allCommand = _repository.GetAllCommand();
            return allCommand;
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(string id)
        {

            var command = _repository.GetCommandById(id);
            return command;
        }

        [HttpPost]
        public void AddCommand([FromBody] Command commandData)
        {
            _repository.AddCommand(commandData);
        }
    }
}