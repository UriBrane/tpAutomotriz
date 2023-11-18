using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Fachada.Interfaz;

namespace TpAutomotrizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IApplication app;
        public ClienteController()
        {
            app = new Application();
        }

        [HttpGet("/cliente")]
        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;
            try
            {
                lst = app.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpGet("/cliente/{id}")]
        public IActionResult GetCliente(int id)
        {
            try
            {
                Cliente c = app.GetCliente(id);
                return Ok(c);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPost("/cliente")]
        public IActionResult PostCliente(Cliente c)
        {
            try
            {
                if (c == null)
                    return BadRequest("Cliente Incorrecto!!");
                return Ok(app.PostCliente(c));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPut("/cliente")]
        public IActionResult PutCliente(Cliente c)
        {
            try
            {
                if (c == null)
                    return BadRequest("Cliente Incorrecto!!");
                return Ok(app.PutCliente(c));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }


    }
}
