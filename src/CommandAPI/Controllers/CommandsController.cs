using System.Collections.Generic;
using System.Linq;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{

        private readonly ICommandAPIRepo _commandAPIRepo;

        public CommandsController(ICommandAPIRepo commandAPIRepo)
        {
            _commandAPIRepo = commandAPIRepo;
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get(){
        //     return new string[] {"this", "is","hard", "coded"};
        // }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands(){
            var commandItems = _commandAPIRepo.GetAllCommands();
            return Ok(commandItems);
        }

         [HttpGet("{Id}")]
        public ActionResult<Command> GetCommandById([FromRoute] int Id){
            var commandItems = _commandAPIRepo.GetCommandById(Id);
            if(commandItems == null){
                return NotFound();
            }
            return Ok(commandItems);
        }
    }
}