using Entidades;
namespace PP_Labo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Numeracion numero = new SistemaDecimal("45");


            Numeracion bin = numero.CambiarSistemaDeNumeracion(ESistema.Binario);
            
            Console.WriteLine(bin.Valor);

            Numeracion dec = bin.CambiarSistemaDeNumeracion(ESistema.Decimal);
            Console.WriteLine(dec.Valor);
        }
    }
}