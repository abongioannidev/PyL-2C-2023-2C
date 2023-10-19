namespace Entidades
{
    public enum EEstaciones { Verano = 12, Otonio = 3, Invierno = 7, Primavera = 9 };

    public static class MetodoExtension
    {
        public static string ObtenerPlacaCronicaAle(this DateTime fecha, EEstaciones estaciones)
        {
            int anio = 2023;
            int mes = (int)estaciones;
            if(fecha.Month > mes)
            {
                anio = 2024;
            }

            DateTime fechaSegunEstacion = new DateTime(anio, (int)estaciones, 21);
            TimeSpan lapsoDeTiempo = fechaSegunEstacion - fecha;

            return $"Falta {lapsoDeTiempo.TotalDays.ToString("0")} para el {estaciones.ToString()}";
        }

        public static string ObtenerPlacaCronicaLucas(this DateTime fecha, EEstaciones e)
        {
            int diasFecha = fecha.DayOfYear;
            int diasDelAnio = new DateTime(fecha.Year, (int)e, 21).DayOfYear;

            if (diasFecha > diasDelAnio)
            {
                diasDelAnio += 365;
            }

            return $"Faltan {diasDelAnio - diasFecha} para el {Enum.GetName(e)}";
        }

    }
}