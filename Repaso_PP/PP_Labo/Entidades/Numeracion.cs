namespace Entidades
{
    public abstract class Numeracion
    {
        protected string valor;
        protected static string msgError;



        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }


        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }


        public string Valor { get { return this.valor; } }
        internal abstract double ValorNumerico { get; }

        /// <summary>
        /// Da un estado inicial al atributo valor de la instancia.
        /// </summary>
        /// <param name="valor">Es el valor que va a tomar la numeracion</param>
        private void InicializaValor(string valor)
        {
            if(this.EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = Numeracion.msgError;
            }
        }
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }


        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1 is not null && n2 is not null && n1.GetType() == n2.GetType();    
        }
        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double (Numeracion numeracion)
        {
            double.TryParse(numeracion.valor, out double result);
            return result;
        }
    }
}