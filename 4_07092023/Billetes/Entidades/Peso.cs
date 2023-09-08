using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        static Peso()
        {
            Peso.cotizRespectoDolar = 800;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacionRespectoDolar()
        {
            return Peso.cotizRespectoDolar;
        }

        public static explicit operator Euro(Peso p)
        {
            Dolar dolar = (Dolar)p;
            Euro euro = (Euro)dolar;
            return euro;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacionRespectoDolar());
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return peso.GetCantidad() == ((Dolar)dolar).GetCantidad();
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso == dolar);
        }


        public static bool operator ==(Peso peso, Euro euro)
        {
            return peso.GetCantidad() == ((Euro)peso).GetCantidad();
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso == euro);
        }


        public static Peso operator +(Peso p1, Peso p2)
        {
            double cantiadad = p1.GetCantidad() + p2.GetCantidad();
            return cantiadad;
        }


        public static Peso operator +(Peso peso, Dolar dolar)
        {
            Peso dolarAPeso = (Peso)dolar;
            double cantidad = peso.GetCantidad() + dolarAPeso.GetCantidad();
            return cantidad;
        }

        public static Peso operator +(Peso peso, Euro euro)
        {
            Peso dolarAPeso = (Peso)euro;
            double cantidad = peso.GetCantidad() + dolarAPeso.GetCantidad();
            return cantidad;
        }


        public static Peso operator -(Peso p1, Peso p2)
        {
            double cantiadad = p1.GetCantidad() - p2.GetCantidad();
            return cantiadad;
        }


        public static Peso operator -(Peso peso, Dolar dolar)
        {
            Peso dolarAPeso = (Peso)dolar;
            double cantidad = peso.GetCantidad() - dolarAPeso.GetCantidad();
            return cantidad;
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            Peso dolarAPeso = (Peso)euro;
            double cantidad = peso.GetCantidad() - dolarAPeso.GetCantidad();
            return cantidad;
        }



    }
}
