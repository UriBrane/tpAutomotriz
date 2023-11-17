using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Fachada.Interfaz;

namespace TpAutomotrizAPI.Controllers
{
    public class OrdenPedidoController : Controller
    {
        private IApplication app;
        public OrdenPedidoController()
        {
            app = new Application();
        }

        [HttpGet("/ordenpedido/consultarid")]
        public IActionResult ConsultarIdOrden()
        {
            try
            {
                int id = 0;
                id = app.ConsultarEscalar("SP_GET_NEXT_ORDEN_PEDIDO", "@next_orden_pedido");
                if (id == 0)
                    return NotFound();
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPost("/ordenpedido")]
        public IActionResult PostOrden(OrdenPedido op)
        {
            try
            {
                if (op == null)
                    return BadRequest("Orden de Pedido Incorrecta!!");
                return Ok(app.PostOrden(op));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

    }
}
