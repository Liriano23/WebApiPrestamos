using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProyectoPrestamo.Models;
using ProyectoPrestamo.BLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPrestamos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/<PrestamosController>
        [HttpGet]
        public ActionResult<List<Prestamos>>Get()
        {
            return PrestamosBLL.GetList(x=> true);
        }

        // GET api/<PrestamosController>/5
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        // POST api/<PrestamosController>
        [HttpPost]
        public void Post([FromBody] Prestamos prestamos)
        {
            PrestamosBLL.Guardar(prestamos);
        }

        // PUT api/<PrestamosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Prestamos prestamos)
        {
            PrestamosBLL.Modificar(prestamos);
        }

        // DELETE api/<PrestamosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PrestamosBLL.Eliminar(id);
        }
    }
}
