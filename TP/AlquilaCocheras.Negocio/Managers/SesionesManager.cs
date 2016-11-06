using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data;

namespace AlquilaCocheras.Negocio.Managers
{
    public static class SesionesManager
    {
        public static void LoguearUsuario(Usuarios usuario)
        {
            if (usuario != null)
            {
                VariblesSesionManager.Guardar(Constantes.USUARIO_LOGUEADO_ID, usuario.IdUsuario);
            }
            else
            {
                throw new Exception("Error: Email o contraseña incorrectos o inexistentes");
            }
        }

        public static bool EsUsuarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);

            return idUsuario != 0;
        }
    }
}