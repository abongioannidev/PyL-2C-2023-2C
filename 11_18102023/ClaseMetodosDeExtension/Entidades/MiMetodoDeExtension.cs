using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraCompilada;



namespace Entidades
{
    public enum EAlgo { Algo, AlgoNuevo };
    public static class MiMetodoDeExtension
    {
        /// <summary>
        /// Ordena una lista de enteros
        /// </summary>
        /// <param name="lista">Es la lista a ordenar</param>
        /// <param name="sentido">True ASC False Des</param>
        /// <returns></returns>
        public static List<int> Ordenar(this List<int> lista,bool sentido)
        {
            if (sentido)
            {
                lista.Sort(); 
                return lista ;
            }

            lista.Sort(FuncionCriterio);
            return lista;
        }

        private static int FuncionCriterio(int num1,int num2)
        {
            return num2 - num1;
        }

        public static int ContarLetras(this string value)
        {
            return value.Length;
        }

        public static int MetodoDelEnum(this EAlgo enu)
        {
            return 10;
        }
    }
}
