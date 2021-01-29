using Microsoft.VisualStudio.TestTools.UnitTesting;
using p.parcial1.Controllers;
using p.parcial1.Models;
using System;

namespace p.parcial1.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetross()
        {
            //arrange
            rossesController Rosscontroller = new rossesController();
            //act
            var rosses = Rosscontroller.Getrosses();
            //assert
            Assert.IsNotNull(rosses);
         
        }
        [TestMethod]
        public void TestMethodPostross()
        {
            //arrange
            rossesController Rosscontroller = new rossesController();
            ross Ross = new ross();
            Ross.Name = "Emily";
            Ross.email = "a2017110728@estudiantes.upsa.edu.bo";
            DateTime Fecha = new DateTime(1998, 03, 20);
            Ross.birthdate = Fecha;
            //act
            var Rosses = Rosscontroller.Postross(Ross);
            //assert
            Assert.IsNotNull(Rosses);





        }
    }
}
