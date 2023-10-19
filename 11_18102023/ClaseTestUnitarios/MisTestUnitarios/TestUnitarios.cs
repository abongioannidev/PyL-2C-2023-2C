using Entidades;

namespace MisTestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        public void AlEnviarElNumeroEnDecimal_SeEsperaObtener_SuEquivalenteEnRomano(int numeroDecimal,string valorEsperado)
        {
            //Arrange
            string resultado = string.Empty;
            //Act
            resultado = Util.ConvertirDecimalARomano(numeroDecimal);
            //Assert
            Assert.AreEqual(valorEsperado, resultado);

        }
        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        public void AlEnviarUnNumeroNegativo_SeEspera_ObtenerUnError()
        {
            //Arrange
            string resultado = string.Empty;
            //Act
            resultado = Util.ConvertirDecimalARomano(-90);

            //Assert
        }
    }
}