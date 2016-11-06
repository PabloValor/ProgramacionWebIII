using System;

namespace AlquilaCocheras.Web.Extensiones
{
    public static class StringExtension
    {
        public static DateTime ToDateTime(this string fecha)
        {
            var array = fecha.Split('/');
            return new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0]));
        }
    }
}
