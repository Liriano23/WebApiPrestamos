using ProyectoPrestamo.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProyectoPrestamo.Models;
using ProyectoPrestamo.DAL;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ProyectoPrestamo.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombre = "PruebaTest";
            personas.Cedula = "00000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;

            paso = PersonasBLL.Guardar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso;
            paso = PersonasBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Personas  personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombre = "Prueba";
            personas.Cedula = "00000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Guardar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 4;
            personas.Nombre = "Juan";
            personas.Cedula = "00000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Modificar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            if (PersonasBLL.Eliminar(6))
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var persona = PersonasBLL.Buscar(1);
            if (persona != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = PersonasBLL.GetList(x=>true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }
    }
}