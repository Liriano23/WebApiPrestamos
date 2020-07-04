using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPrestamo.BLL;
using ProyectoPrestamo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPrestamo.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 0;
            prestamos.PersonaID = 7;
            prestamos.Fecha = DateTime.Now;
            prestamos.Concepto = "PrestamoTest";
            prestamos.Monto = 1500;
            prestamos.Balance = 0;


            paso = PrestamosBLL.Guardar(prestamos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso;
            paso = PrestamosBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 0;
            prestamos.PersonaID = 7;
            prestamos.Fecha = DateTime.Now;
            prestamos.Concepto = "PrestamoTest";
            prestamos.Monto = 1500;
            prestamos.Balance = 0;


            paso = PrestamosBLL.Insertar(prestamos);
            PrestamosBLL.LlenarBalance(prestamos.PersonaID,prestamos.Balance);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 7;
            prestamos.PersonaID = 7;
            prestamos.Monto = 5000;
            prestamos.Balance = 1500;

            var persona = PersonasBLL.Buscar(prestamos.PersonaID);
            decimal balanceActual = persona.Balance;

            PrestamosBLL.Modificar(prestamos);
            PrestamosBLL.LlenarBalance(prestamos.PersonaID, prestamos.Balance);

            persona = PersonasBLL.Buscar(prestamos.PersonaID);

            if (persona.Balance == balanceActual)
                paso = false;
            else
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            var persona = PersonasBLL.Buscar(5);
            decimal balanceActual = persona.Balance;
            PrestamosBLL.Eliminar(5);
            PrestamosBLL.RemoverPrestamo(5);
            persona = PersonasBLL.Buscar(5);

            if (persona.Balance == balanceActual)
                paso = false;
            else
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var prestamo = PrestamosBLL.Buscar(1);

            if (prestamo != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = PrestamosBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void LlenarBalanceTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 7;
            prestamos.PersonaID = 7;
            prestamos.Monto = 5000;
            prestamos.Balance = 100;

            var persona = PersonasBLL.Buscar(prestamos.PersonaID);
            decimal balanceActual = persona.Balance;

            PrestamosBLL.Modificar(prestamos);
            PrestamosBLL.LlenarBalance(prestamos.PersonaID, prestamos.Balance);

            persona = PersonasBLL.Buscar(prestamos.PersonaID);

            if (persona.Balance == balanceActual)
                paso = false;
            else
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarInscripcionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoverPrestamoTest()
        {
            bool paso;
            var persona = PersonasBLL.Buscar(7);
            decimal balanceActual = persona.Balance;
            PrestamosBLL.Eliminar(7);
            PrestamosBLL.RemoverPrestamo(7);
            persona = PersonasBLL.Buscar(7);

            if (persona.Balance == balanceActual)
                paso = false;
            else
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}