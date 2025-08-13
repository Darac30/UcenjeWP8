using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]  // Ruta će se javiti na /api/v1/HttpMetode
    public class HttpMetodeController : ControllerBase
    {
        // ruta me metoda

        // ovdje počinje ruta

        [HttpGet]
        public string HelloWorld()
        {

            return "hello";
        
        
        }



        // ovdje završava ruta

        // ovdje počinje ruta

        [HttpGet]
        [Route("pozdrav")]

        public string HelloWorld(string ime)
        {
            return new StringBuilder().Append("Hello ").Append(ime).ToString();
        }

        // ovdje završava ruta


        [HttpGet]
        [Route("json")]

        public IActionResult Json()
        {
            // metoda Ok je došla iz ControllerBase nadklase
            return Ok(new { Ime = "Pero", Prezime = "Perić" }); // ovo nije OOP

        }

        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            // ovdje će ići spremanje u bazu
            return StatusCode(StatusCodes.Status201Created, osoba);
        }

        [HttpPut]
        public IActionResult Put(Osoba o)
        {
            o.Ime = "Promjenio " + o.Ime;

            return Ok(o);
        }

        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if(sifra <= 0)
            {
                return BadRequest(new { poruka = "Sifra mora biti veca od 0" });
            }

            return NoContent();
        }





    }
}
