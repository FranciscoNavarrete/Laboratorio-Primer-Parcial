using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using FormularioJardin;
using System.Collections.Generic;


namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDNIException))]
        public void PersonaSinDni()
        {
            Alumno al = new Alumno("pepe", "popia", 0, false, 2500);
            al.Dni = 0;
        }
        [TestMethod]
        public void PersonaDniValido()
        {
            Alumno al = new Alumno("pepe", "popia", 37995721, false, 2500);
            Assert.IsNotNull(al);
        }

        //Hola
        //[TestMethod]
        //public void CreateValueTest()
        //{
        //    MenPrincipal menprin = new MenPrincipal();
        //    menprin.CreoObjDefault_Click();

        //    Assert.IsTrue(menprin.ListaDocentes.Count == 6 && menprin.ListaAlumnos.Count == 50);
        //}

        //Prueba con interfaz
        //[TestMethod]
        //public void PruebaInterface()
        //{
        //    List<IMensaje> listaMsj = new List<IMensaje>();

        //    Docente d1 = new Docente("Jose", "Perez", 2145786, false, Convert.ToDateTime("1/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d2= new Docente("Julia", "Venecia", 7123658, true, Convert.ToDateTime("2/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d3 = new Docente("Elvira", "Alvez", 21458712, true, Convert.ToDateTime("3/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d4 = new Docente("Marta", "Rodri", 11245856, false, Convert.ToDateTime("4/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);
        //    Docente d5 = new Docente("Carlos", "Teki", 12458965, true, Convert.ToDateTime("5/3/2000 12:00:00 AM"), Convert.ToDateTime("31/3/2010 5:00:00 PM"), 200);

        //    listaMsj.Add(d1);
        //    listaMsj.Add(d2);
        //    listaMsj.Add(d3);
        //    listaMsj.Add(d4);
        //    listaMsj.Add(d5);

        //    listaMsj.Add(new Aula(EColores.Amarillo, ETurno.Mañana, d1));
        //    listaMsj.Add(new Aula(EColores.Rojo, ETurno.Tarde, d2));
        //    listaMsj.Add(new Aula(EColores.Verde, ETurno.Mañana, d3));
        //    listaMsj.Add(new Aula(EColores.Amarillo, ETurno.Tarde, d4));

        //    string salida = "";
        //    foreach (IMensaje item in listaMsj)
        //    {
        //        item.MostrarMensaje();
        //    }

        //    Assert.IsTrue(salida.Length > 200);
        //}

    }
}
