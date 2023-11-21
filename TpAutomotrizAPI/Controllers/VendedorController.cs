using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Fachada.Interfaz;
using TpAutomotrizBack.Servicios;

namespace TpAutomotrizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private IApplication app;
        public VendedorController(AbstractFactoryDAO factory)
        {
            app = new Application(factory);
        }

        [HttpGet("/vendedor")]
        public IActionResult GetVendedores()
        {
            List<Vendedor> lst;
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

        [HttpGet("/vendedor/{id}")]
        public IActionResult GetVendedor(int id)
        {
            try
            {
                Vendedor v = app.GetVendedor(id);
                return Ok(v);
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

        [HttpPut("/vendedor")]
        public IActionResult PutVendedor(Vendedor v)
        {
            try
            {
                if (v == null)
                    return BadRequest("Vendedor Incorrecto!");
                return Ok(app.PutVendedor(v));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

    }
}
