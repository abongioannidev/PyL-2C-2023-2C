using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacionRespectoDolar()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Peso.GetCotizacionRespectoDolar() * d.GetCantidad());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacionRespectoDolar());
        }


        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return dolar.GetCantidad() == ((Dolar)euro).GetCantidad();
        }
        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return dolar.GetCantidad() == ((Dolar)peso).GetCantidad();
        }
        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar == peso);
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            double cantidad = d1.GetCantidad() + d2.GetCantidad();

            return cantidad;
        }
        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar euroADolar = (Dolar)euro;
            double cantidad = dolar.GetCantidad() + euroADolar.GetCantidad();
            return cantidad;
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            Dolar pesoADolar = (Dolar)peso;
            double cantidad = dolar.GetCantidad() + pesoADolar.GetCantidad();
            return cantidad;
        }


        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            double cantidad = d1.GetCantidad() - d2.GetCantidad();

            return cantidad;
        }
        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar euroADolar = (Dolar)euro;
            double cantidad = dolar.GetCantidad() - euroADolar.GetCantidad();
            return cantidad;
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            Dolar pesoADolar = (Dolar)peso;
            double cantidad = dolar.GetCantidad() - pesoADolar.GetCantidad();
            return cantidad;
        }


    }


}
