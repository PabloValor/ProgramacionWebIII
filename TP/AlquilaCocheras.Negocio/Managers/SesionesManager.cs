using AlquilaCocheras.Data.Constantes;

namespace AlquilaCocheras.Negocio.Managers
{
    public static class SesionesManager
    {
        public static void LoguearUsuario(string mailUsuario, string contrasena)
        {
            var existeUsuario = (mailUsuario == "cliente@gmail.com" && contrasena == "Password1") ||
                                (mailUsuario == "propietario@gmail.com" && contrasena == "Password1");

            if (existeUsuario)
            {
                VariblesSesionManager.Guardar(Constantes.USARIO_LOGUEADO_OK, mailUsuario); // TODO: guardar el Id de Usuario, no el mail
            }
            else
            {
                // mandar mensaje de error 
            }
        }

        public static bool EsUsuarioLogueado()
        {
            return !string.IsNullOrEmpty(VariblesSesionManager.Obtener<string>(Constantes.USARIO_LOGUEADO_OK));
        }
    }
}
