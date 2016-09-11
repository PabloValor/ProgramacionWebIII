using System.Web;

namespace AlquilaCocheras.Web.Helpers
{
    public static class EntornoHelper
    {
        public static bool EsLocalhost()
        {
            return HttpContext.Current.Request.IsLocal;
        }
    }
}