using Entidades.excepciones;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {

                MiClase mi = new MiClase(10);
            }
            catch (DivideByZeroException ex)
            {
                Exception ex2 = ex;
                throw new UnaExcepcion("Excepcion capturada en el ctor sin parametros y re lanzada", ex);
            }

        }
        public MiClase(int id)
        {

            try
            {

                MiClase.MiMetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {

                throw;
            }

        }

        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException("Excepcion lanzada en mi metodo estatico de MiClase");
        }

    }
}