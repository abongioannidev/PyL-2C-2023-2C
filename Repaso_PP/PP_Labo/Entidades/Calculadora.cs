using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;

        private static ESistema sistema;
        private List<string> operaciones;
        private string nombreAlumno;

        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public Numeracion Resultado { get => resultado; }
        public static ESistema Sistema { get => sistema; set => sistema = value; }
        public List<string> Operaciones { get => operaciones; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }

        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            this.operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno) : this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public void Calcular()
        {
            this.Calcular('+');
        }

        public void Calcular(char operador)
        {
            double resultado = double.MinValue;
            if (this.primerOperando == this.segundoOperando)
            {
                switch (operador)
                {
                    case '-':
                        resultado = this.primerOperando.ValorNumerico - this.segundoOperando.ValorNumerico;

                        break;

                    case '*':
                        resultado = this.primerOperando.ValorNumerico * this.segundoOperando.ValorNumerico;
                        break;
                    case '/':

                        resultado = this.primerOperando.ValorNumerico / this.segundoOperando.ValorNumerico;
                        break;

                    default:

                        resultado = this.primerOperando.ValorNumerico + this.segundoOperando.ValorNumerico;
                        break;

                }

            }

            this.resultado = this.MapeaResultado(resultado);

        }

        private Numeracion MapeaResultado(double valor)
        {
            Numeracion resultado = (SistemaDecimal)valor.ToString();
            return resultado.CambiarSistemaDeNumeracion(Calculadora.sistema);
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[{Calculadora.Sistema}] => {this.primerOperando.Valor} {operador} {this.segundoOperando.Valor} = {this.resultado.Valor} ");

            this.operaciones.Add(sb.ToString());
        }


        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }



    }
}
