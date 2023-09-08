namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.93;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacionRespectoDolar()
        {
            return Euro.cotizRespectoDolar;
        }


        public static explicit operator Peso(Euro e)
        {
            Dolar dolar = (Dolar)e;
            Peso peso = (Peso)dolar;
            return peso;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() / Euro.GetCotizacionRespectoDolar());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }


        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return euro.GetCantidad() == ((Euro)dolar).GetCantidad();
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            return euro.GetCantidad() == ((Euro)peso).GetCantidad();
        }


        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == peso);
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            double cantidad = e1.GetCantidad() + e2.GetCantidad();

            return cantidad;
        }
        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro dolarAEuro = (Euro)dolar;
            double cantidad = euro.GetCantidad() + dolarAEuro.GetCantidad();
            return cantidad;
        }

        public static Euro operator +(Euro dolar, Peso peso)
        {
            Euro pesoAEuro = (Euro)peso;
            double cantidad = dolar.GetCantidad() + pesoAEuro.GetCantidad();
            return cantidad;
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            double cantidad = e1.GetCantidad() - e2.GetCantidad();

            return cantidad;
        }
        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro dolarAEuro = (Euro)dolar;
            double cantidad = euro.GetCantidad() - dolarAEuro.GetCantidad();
            return cantidad;
        }

        public static Euro operator -(Euro dolar, Peso peso)
        {
            Euro pesoAEuro = (Euro)peso;
            double cantidad = dolar.GetCantidad() - pesoAEuro.GetCantidad();
            return cantidad;
        }

    }
}