using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() 
            { 
                new Autor() { iId = 1, sNombre ="Felipe" },
                new Autor() { iId = 2, sNombre ="Oscar" },
                new Autor() { iId = 3, sNombre ="Carlos" }
            };
        }
    }
}
