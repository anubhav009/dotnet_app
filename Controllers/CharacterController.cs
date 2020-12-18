using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Properties.Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        //private static Character knight = new Character();
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Name ="Sam"}
        };

public IActionResult Get(){

    return Ok(characters);
}

    }
}