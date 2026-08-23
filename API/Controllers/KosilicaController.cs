using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Services;
using Domain;
using ApplicationLogic;
using System.Collections.Generic;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class KosilicaController : ControllerBase
    {
        public KosilicaController()
        {
        }

        //GET
        [HttpGet]
        public ActionResult<List<Kosilica>> GetAll() => ApplicationLogic.Controller.Instance.VratiListuSveKosilica();

        //GET By ID
        [HttpGet("{id}")]
        public ActionResult<Kosilica> Get(int id)
        {
            var list = ApplicationLogic.Controller.Instance.VratiListuSveKosilica();

            var exists = list.FirstOrDefault(x => x.IdKosilica == id);

            if (exists == null) return NotFound();

            return list[id];
        }

        // POST
        [HttpPost]
        public IActionResult Create(Kosilica kosilica)
        {
            ApplicationLogic.Controller.Instance.KreirajKosilica(kosilica);

            return CreatedAtAction(nameof(Get), new { id = kosilica.IdKosilica }, kosilica);
        }


        // PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, Kosilica kosilica)
        {
            if (id != kosilica.IdKosilica)
                return BadRequest();

            var existingKosilica = ApplicationLogic.Controller.Instance.VratiListuSveKosilica().FirstOrDefault(x => x.IdKosilica == id);
            if (existingKosilica is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.PromeniKosilica(kosilica);

            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var kosilica = ApplicationLogic.Controller.Instance.VratiListuSveKosilica().FirstOrDefault(x => x.IdKosilica == id);

            if (kosilica is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.ObrisiKosilica(kosilica);

            return NoContent();
        }
    }
}
