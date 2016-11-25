using System;

namespace AlquilaCocheras.Web.Extensiones
{
    public static class StringExtension
    {
        public static DateTime ToDateTime(this string fechaEntrada, string hora)
        {
            var arrayFecha = fechaEntrada.Split('/');
            var arrayHora = hora.Split(':');

                return new DateTime(int.Parse(arrayFecha[2]), int.Parse(arrayFecha[1]), int.Parse(arrayFecha[0]),
                    int.Parse(arrayHora[0]), int.Parse(arrayHora[1]), 0);
        }

        public static string Truncar(this string textoOriginal, int largoMaximo)
        {
            var largoActual = textoOriginal.Length;

            if (largoActual > largoMaximo)
            {
                var subcadena = textoOriginal.Substring(0, largoMaximo).Trim();

                var textoTruncado =  subcadena.Length > 3 ? subcadena.Replace(subcadena.Substring(subcadena.Length - 3), "...") : subcadena;

                return textoTruncado;
            }
            return textoOriginal;
        }
    }
}
