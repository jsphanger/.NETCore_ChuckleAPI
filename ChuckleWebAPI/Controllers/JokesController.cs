using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private JokeServer server { get; set; }

        public JokesController()
        {
            server = new JokeServer();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(server.GetAllJokes());
        }

        [HttpGet("Random")]
        public IActionResult GetRandom()
        {
            return Ok(server.GetRandomJoke());
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int id)
        {
            var joke = server.GetJokeByID(id);

            if (joke != null)
                return Ok(server.GetJokeByID(id));
            else
                return NotFound();
        }

    }
}