
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class Ave : IVolador,IAlimentar
    {

        public bool Alimentar
        {
            get
            {
                return this.Combustible > 8;
            }
            set
            {
                if (value)
                {
                    this.Combustible = 10;
                }
            }
        }
        public int Combustible { get { return 10; } private set { } }

        string IVolador.Aterrizar()
        {
            return "Ave Aterrizando";
        }



        public string Despegar()
        {
            return "Ave despegando";
        }
    }
}
