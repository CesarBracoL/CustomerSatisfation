using AppWebSite.Helpers;
using AppWebSite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppWebSite.UnitTest
{
    [TestClass]
    public class ServicesEncuestaTest
    {
        [TestMethod]
        public void puedeRegistrar_EncuestaEncontradaNull_NoValido()
        {
            //Arrange
            Encuesta encuestaEncontrada = null;
            Encuesta encuestaARegistrar = null;

            //Act
            bool result = ServicesEncuesta.puedeRegistrar(encuestaEncontrada, encuestaARegistrar);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void puedeRegistrar_EncuestasIgualEmailDifFecha_Valido()
        {
            //
            var encuestaEncontrada = new Encuesta();
            encuestaEncontrada.Enemail = "persona1@gmail.com";
            encuestaEncontrada.Ennombre = "primer registro";
            encuestaEncontrada.Encalificacion = 2;
            encuestaEncontrada.Enfecha = new System.DateTime(2020, 01, 08);

            var encuestaARegistrar = new Encuesta();
            encuestaARegistrar.Enemail = "persona1@gmail.com";
            encuestaARegistrar.Ennombre = "segundo registro";
            encuestaARegistrar.Encalificacion = 3;
            encuestaARegistrar.Enfecha = new System.DateTime(2020, 01, 09);

            //
            bool result = ServicesEncuesta.puedeRegistrar(encuestaEncontrada, encuestaARegistrar);

            //

            Assert.IsTrue(result);

        }


    }
}
