using System.Web;

namespace AlquilaCocheras.Negocio.Managers
{
    public static class VariblesSesionManager
    {
        public static void Guardar<T>(string clave, T valor)
        {
            HttpContext.Current.Session[clave] = valor;
        }

        public static T Obtener<T>(string clave)
        {
            var valor = HttpContext.Current.Session[clave];
            return (T) valor; 
        }

        public static void Eliminar(string clave)
        {
            HttpContext.Current.Session.Remove(clave);
        }
    }
}
