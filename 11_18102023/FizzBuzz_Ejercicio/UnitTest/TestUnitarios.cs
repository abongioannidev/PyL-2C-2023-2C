using Entidades;
namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(4, "4")]
        [DataRow(7, "7")]
        [DataRow(8, "8")]
        [DataRow(13, "13")]
        [DataRow(14, "14")]
        [DataRow(16, "16")]
        public void Al_InvocarAlMetodoDeInstanciaDeInt_SiNoEsDivisiblePor3o5_DeberiaObtenerElNumeroEnString(int valor, string valorEsperado)
        {
            string resultado = valor.FizzBuzz();
            Assert.AreEqual(resultado, valorEsperado);
        }
        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(9, "Fizz")]
        [DataRow(12, "Fizz")]
        [DataRow(18, "Fizz")]
        [DataRow(21, "Fizz")]
        public void Al_InvocarAlMetodoDeInstanciaDeInt_SiEsDivisiblePor3_DeberiaObtenerFizz(int valor, string valorEsperado)
        {
            string resultado = valor.FizzBuzz();
            Assert.AreEqual(resultado, valorEsperado); 
        }
        [TestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(20, "Buzz")]
        [DataRow(25, "Buzz")]
        [DataRow(35, "Buzz")]
        public void Al_InvocarAlMetodoDeInstanciaDeInt_SiEsDivisiblePor5_DeberiaObtenerBuzz(int valor, string valorEsperado)
        {
            string resultado = valor.FizzBuzz();
            Assert.AreEqual(resultado, valorEsperado);
        }

        [TestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        [DataRow(60, "FizzBuzz")]
        public void Al_InvocarAlMetodoDeInstanciaDeInt_SiEsDivisiblePor3y5_DeberiaObtenerFizzBuzz(int valor, string valorEsperado)
        {
            string resultado = valor.FizzBuzz();
            Assert.AreEqual(resultado, valorEsperado);
        }
    }
}