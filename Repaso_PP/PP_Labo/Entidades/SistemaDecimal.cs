using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return (double)this;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch(sistema)
            {
                case ESistema.Binario:
                    return this.DecimalABinario();

            }
            return this;
        }

        protected override bool EsNumeracionValida(string value)
        {
            return base.EsNumeracionValida(value) && this.EsSistemaDecimalValido(value);
        }

        private bool EsSistemaDecimalValido(string value)
        {
            return double.TryParse(value,out double valor);
        }
        private SistemaBinario DecimalABinario()
        {
            int valor = (int)this.ValorNumerico;

            if(valor > 0)
            {
                string binario = string.Empty;
                while(valor > 0)
                {
                    int resto = valor % 2;
                    valor = valor / 2;
                    binario = resto + binario;
                }
                return binario;
            }
            return Numeracion.msgError;
        }


        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
    }
}
