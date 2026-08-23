using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoslovniPartnerController : ControllerBase
    {
        public PoslovniPartnerController()
        {
        }

        //GET
        [HttpGet]
        public ActionResult<List<PoslovniPartner>> GetAll() => ApplicationLogic.Controller.Instance.VratiListuSviPoslovniPartner();

        //GET By ID
        [HttpGet("{id}")]
        public ActionResult<PoslovniPartner> Get(int id)
        {
            var list = ApplicationLogic.Controller.Instance.VratiListuSviPoslovniPartner();

            var exists = list.FirstOrDefault(x => x.IdPoslovniPartner == id);

            if (exists == null) return NotFound();

            return list[id];
        }

        // POST
        [HttpPost]
        public IActionResult Create(PoslovniPartner pp)
        {
            ApplicationLogic.Controller.Instance.KreirajPoslovniPartner(pp);

            return CreatedAtAction(nameof(Get), new { id = pp.IdPoslovniPartner }, pp);
        }


        // PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, PoslovniPartner pp)
        {
            if (id != pp.IdPoslovniPartner)
                return BadRequest();

            var existingKosilica = ApplicationLogic.Controller.Instance.VratiListuSviPoslovniPartner().FirstOrDefault(x => x.IdPoslovniPartner == id);
            if (existingKosilica is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.PromeniPoslovniPartner(pp);

            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pp = ApplicationLogic.Controller.Instance.VratiListuSviPoslovniPartner().FirstOrDefault(x => x.IdPoslovniPartner == id);

            if (pp is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.ObrisiPoslovniPartner(pp);

            return NoContent();
        }
    }
}
