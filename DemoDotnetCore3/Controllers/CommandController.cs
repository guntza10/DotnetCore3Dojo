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
        private readonly ICommanderService _commanderService;

        public CommandController(ICommanderService commanderService)
        {
            _commanderService = commanderService;
        }

        [HttpGet]
        public ActionResult<List<Command>> GetAllCommand()
        {
            var allCommand = _commanderService.GetAllCommand();
            return Ok(allCommand);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(string id)
        {
            var command = _commanderService.GetCommandById(id);
            return Ok(command);
        }

        [HttpPost]
        public void AddCommand([FromBody] Command commandData)
        {
            _commanderService.AddCommand(commandData);
        }
    }
}