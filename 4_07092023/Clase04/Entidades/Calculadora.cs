namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Devuelve la suma por defecto de los 2 operadores
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <returns></returns>
        public static double Operar(int operadorUno, int operadorDos)
        {
            return operadorUno + operadorDos;
        }


        /// <summary>
        /// Realiza una operacion matematica en base a su operador
        /// </summary>
        /// <param name="operadorUno">Primer operador</param>
        /// <param name="operadorDos">Segundo operador</param>
        /// <param name="operador">Es el caracter que representa la operacion a realizar</param>
        /// <returns></returns>
        public static double Operar(int operadorUno, int operadorDos, char operador)
        {
            switch (operador)
            {
                case '-':
                    return operadorUno - operadorDos;
                case '*':
                    return operadorUno * operadorDos;
                case '/':
                    return (double)operadorUno / operadorDos;
                default:
                    return Calculadora.Operar(operadorUno, operadorDos);
            }
        }



        public static int Sumar(int operadorUno, int operadorDos)
        {
            return operadorUno + operadorDos;

        }

        public static int Sumar(string operadorUno, string operadorDos)
        {
            int.TryParse(operadorUno, out int operadotUnoNumero);
            int.TryParse(operadorDos, out int operadotDosNumero);

            return Calculadora.Sumar(operadotUnoNumero, operadotDosNumero);
        }

    }
}