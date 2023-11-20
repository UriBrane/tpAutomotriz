using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Interfaz;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Servicios;

namespace TpAutomotrizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : Controller
    {
        private IApplication app;
        public FacturaController(AbstractFactoryDAO factory)
        {
            app = new Application(factory);
        }

        [HttpGet("/factura")]
        public IActionResult GetFacturas()
        {
            List<Factura> lst;
            try
            {
                lst = app.GetFacturas();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpGet("/factura/{id}")]
        public IActionResult GetFactura(int id)
        {
            try
            {
                Factura fac = app.GetFactura(id);
                return Ok(fac);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpGet("/factura/consultarid")]
        public IActionResult ConsultarIdFactura()
        {
            try
            {
                int id = 0;
                id = app.ConsultarEscalar("SP_GET_NEXT_FACTURA", "@nro");
                if (id == 0)
                    return NotFound();
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPost("/factura")]
        public IActionResult PostFactura(Factura fac)
        {
            try
            {
                if (fac == null)
                    return BadRequest("Orden de Pedido Incorrecta!!");
                return Ok(app.PostFactura(fac));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }
    }
}
