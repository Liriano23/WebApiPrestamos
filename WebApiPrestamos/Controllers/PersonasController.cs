﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoPrestamo.BLL;
using ProyectoPrestamo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPrestamos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        // GET: api/Personas
        [HttpGet]
        public ActionResult<List<Personas>> Get()
        {
            return PersonasBLL.GetList(x=> true);
        }

        // GET: api/Personas/5
        [HttpGet("{id}")]
        public ActionResult<Personas> Get(int id)
        {
            return PersonasBLL.Buscar(id);
        }

        // POST: api/Personas
        [HttpPost]
        public void Post([FromBody] Personas personas)
        {
            PersonasBLL.Guardar(personas);
        }

        // PUT: api/Personas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Personas personas)
        {
            PersonasBLL.Modificar(personas);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonasBLL.Eliminar(id);
        }
    }
}
