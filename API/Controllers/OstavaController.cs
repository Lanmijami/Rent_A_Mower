using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OstavaController : ControllerBase
    {
        public OstavaController()
        {
        }

        //GET
        [HttpGet]
        public ActionResult<List<Ostava>> GetAll() => ApplicationLogic.Controller.Instance.VratiListuSveOstava();

        //GET By ID
        [HttpGet("{id}")]
        public ActionResult<Ostava> Get(int id)
        {
            var list = ApplicationLogic.Controller.Instance.VratiListuSveOstava();

            var exists = list.FirstOrDefault(x => x.IdOstava == id);

            if (exists == null) return NotFound();

            return list[id];
        }

        // POST
        [HttpPost]
        public IActionResult Create(Ostava ostava)
        {
            ApplicationLogic.Controller.Instance.KreirajOstava(ostava);

            return CreatedAtAction(nameof(Get), new { id = ostava.IdOstava }, ostava);
        }


        // PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, Ostava ostava)
        {
            if (id != ostava.IdOstava)
                return BadRequest();

            var existingKosilica = ApplicationLogic.Controller.Instance.VratiListuSveOstava().FirstOrDefault(x => x.IdOstava == id);
            if (existingKosilica is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.PromeniOstava(ostava);

            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ostava = ApplicationLogic.Controller.Instance.VratiListuSveOstava().FirstOrDefault(x => x.IdOstava == id);

            if (ostava is null)
                return NotFound();

            ApplicationLogic.Controller.Instance.ObrisiOstava(ostava);

            return NoContent();
        }
    }
}
