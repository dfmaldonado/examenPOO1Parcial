using Microsoft.AspNetCore.Mvc;
using ExamenUnidad1Poo.Controllers;


namespace ExamenUnidad1Poo.Controllers
{
    [ApiController]
    [Route("[LogicController]")]
    public class Validaciones 
    {
        [HttpGet("is-prime/{number}")]
        public IActionResult EsPrimo(int number)
        {

        }

    }
}