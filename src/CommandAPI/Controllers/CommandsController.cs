using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{
     
        public ActionResult<IEnumerable<string>> Get(){

        }
    }
}