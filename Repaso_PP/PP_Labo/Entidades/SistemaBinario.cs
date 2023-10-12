using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return (double)this.CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                    return this.BinarioADecimal();

            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string value)
        {
            foreach (char item in value)
            {
                if (item < '0' || item > '1')
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            if (base.valor != Numeracion.msgError)
            {
                int potencia = base.valor.Length - 1;
                int resultado = 0;

                foreach(char item in base.valor)
                {
                    if( item == '1')
                    {
                        resultado = resultado + (int)Math.Pow(2, potencia);
                    }
                    potencia--; 
                }
                return resultado;

            }
            return double.MinValue;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
