using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace rpg_game_dotnet.Controllers
{

        [ApiController]
        [Route("api/[controller]")]

        public class CharacterController : ControllerBase
        {
            private static Character Monk = new Character();
        
            [HttpGet]
            public ActionResult<Character> Get()
            {
            
                return Ok(Monk);
            }
        }
    }
