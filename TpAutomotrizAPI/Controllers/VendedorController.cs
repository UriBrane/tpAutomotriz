using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Fachada.Interfaz;

namespace TpAutomotrizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private IApplication app;
        public VendedorController()
        {
            app = new Application();
        }

        [HttpGet("/vendedor")]
        public IActionResult GetVendedores()
        {
            List<Vendedor> lst = null;
            try
            {
                lst = app.GetVendedores();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPost("/vendedor")]
        public IActionResult PostVendedor(Vendedor v)
        {
            try
            {
                if (v == null)
                    return BadRequest("Vendedor Incorrecto!");
                return Ok(app.PostVendedor(v));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }
    }
}
