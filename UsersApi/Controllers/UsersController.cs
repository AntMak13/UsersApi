using Microsoft.AspNetCore.Mvc;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromBody] UserModel user)
        {
            return Ok();
        }
        

        [HttpPut]
        public IActionResult Update([FromBody] UserModel user)
        {
            return Ok();
        }
        
        [HttpPatch("recovery/{id}")]
        public IActionResult Recover(int id)
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}

