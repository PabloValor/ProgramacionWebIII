using System;
using System.Linq;
using System.Net.Mime;

namespace AlquilaCocheras.Web.Extensiones
{
    public static class StringExtension
    {
        public static DateTime ToDateTime(this string fecha)
        {
            var array = fecha.Split('/');
            return new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0]));
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
