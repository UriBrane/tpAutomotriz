﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Implementacion;
using TpAutomotrizBack.Fachada.Interfaz;
using TpAutomotrizBack.Servicios;

namespace TpAutomotrizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IApplication app;
        public ProductoController(AbstractFactoryDAO factory)
        {
            app = new Application(factory);
        }

        [HttpGet("/producto")]
        public IActionResult GetProductos()
        {
            List<Producto> lst = null;
            try
            {
                lst = app.GetProductos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpGet("/productos/{idTipo}")]
        public IActionResult GetProductos(int idTipo)
        {
            try
            {
                List<Producto> p = app.GetProductos(idTipo);
                return Ok(p);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpGet("/producto/{id}")]
        public IActionResult GetProducto(int id)
        {
            try
            {
                Producto p = app.GetProducto(id);
                return Ok(p);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPost("/producto")]
        public IActionResult PostProducto(Producto p)
        {
            try
            {
                if(p == null)
                    return BadRequest("Producto Incorrecto!!");
                return Ok(app.PostProducto(p));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

        [HttpPut("/producto")]
        public IActionResult PutVendedor(Producto p)
        {
            try
            {
                if (p == null)
                    return BadRequest("Producto Incorrecto!");
                return Ok(app.PutProducto(p));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error !!! " + ex.Message);
            }
        }

    }
}
