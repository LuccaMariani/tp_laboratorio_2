using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAgregarAlDeposito()
        {
            // Arrange
            Auricular auri1 = new Auricular(Color.Dorado, false, Modelo.SeriePremium);
            Auricular auri2 = new Auricular(Color.Rosa, true, Modelo.SerieA);
            Teclado tecladito1 = new Teclado(Color.Negro, ColorLuces.RGB, true, Modelo.SeriePremium, EtipoTeclado.Ochenta);
            Teclado tecladito2 = new Teclado(Color.Negro, ColorLuces.RGB, false, Modelo.SeriePremium, EtipoTeclado.Ochenta);

            DepositoFabrica<Periferico> deposito = new DepositoFabrica<Periferico>("nombreDeposito 2", 10);

            bool auri1Agregado;
            bool auri2Agregado;
            bool tecladito1Agregado;
            bool tecladito2Agregado;

            // Act
            auri1Agregado = deposito.AgregarAlDeposito(auri1);
            auri2Agregado = deposito.AgregarAlDeposito(auri2);
            tecladito1Agregado = deposito.AgregarAlDeposito(tecladito1);
            tecladito2Agregado = deposito.AgregarAlDeposito(tecladito2);

            // Assert
            Assert.IsTrue(auri1Agregado);
            Assert.IsTrue(auri2Agregado);
            Assert.IsTrue(tecladito1Agregado);
            Assert.IsTrue(tecladito2Agregado);
        }

        [TestMethod]
        public void TestRemoverDelDeposito()
        {
            // Arrange
            Auricular auri1 = new Auricular(Color.Dorado, false, Modelo.SeriePremium);
            Teclado tecladito1 = new Teclado(Color.Negro, ColorLuces.RGB, true, Modelo.SeriePremium, EtipoTeclado.Ochenta);
            DepositoFabrica<Periferico> deposito = new DepositoFabrica<Periferico>("nombreDeposito 2", 10);
            bool auri1Removido;
            bool tecladito1Removido;

            // Act
            deposito.AgregarAlDeposito(auri1);
            deposito.AgregarAlDeposito(tecladito1);

            auri1Removido = deposito.RemoverDelDeposito(auri1);
            tecladito1Removido = deposito.RemoverDelDeposito(tecladito1);

            // Assert
            Assert.IsTrue(auri1Removido);
            Assert.IsTrue(tecladito1Removido);

        }

        [TestMethod]
        public void TestGuardar_Cargar()
        {
            // Arrange
            Auricular auri1 = new Auricular(Color.Dorado, false, Modelo.SeriePremium);
            Teclado tecladito1 = new Teclado(Color.Negro, ColorLuces.RGB, true, Modelo.SeriePremium, EtipoTeclado.Ochenta);

            DepositoFabrica<Periferico> deposito = new DepositoFabrica<Periferico>("nombreDeposito 2", 10);

            // Act
            deposito.AgregarAlDeposito(auri1);
            deposito.AgregarAlDeposito(tecladito1);

            deposito.GuardarFabrica(deposito, "testDeposito");

            // Assert
            Assert.AreEqual(deposito.ToString(), deposito.CargarFabrica(deposito, "testDeposito").ToString());

        }
    }
}