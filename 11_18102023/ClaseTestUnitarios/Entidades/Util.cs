using System.Text;

namespace Entidades
{
    public class Util
    {
        public static string ConvertirDecimalARomano(int v)
        {
         
            if( v < 1)
            {
                throw new NumeroInvalidoException("No se acepta negativos");
            }
            return Util.ConvertirUnidades(v);
        }
        

        private static string ConvertirUnidades(int valor)
        {

            if (valor < 4)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append('I', valor);
                return stringBuilder.ToString();

            }
            if(valor == 4)
            {
                return "IV";
            }

            if(valor > 4 && valor < 9)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append('V');
                stringBuilder.Append('I', valor - 5);
                return stringBuilder.ToString();

            }
            if( valor == 9) 
            {
                return "IX";
            }

            return "ERROR";

        }
    }
}