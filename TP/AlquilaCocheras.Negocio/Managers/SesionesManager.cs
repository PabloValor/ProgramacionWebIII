using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Negocio.Managers
{
    public static class SesionesManager
    {
        public static void LoguearUsuario(string mailUsuario, string contrasena)
        {
            var _usuarioService = new UsuarioService();

            var existeUsuario = _usuarioService.ObtenerClientePorEmailYContrasena(mailUsuario, contrasena) != null;

            if (existeUsuario)
            {
                var usuario = _usuarioService.ObtenerUsuarioPorEmail(mailUsuario);

                VariblesSesionManager.Guardar(Constantes.USUARIO_LOGUEADO_ID, usuario.Id);
            }
            else
            {
                throw new Exception("Error: Email o contraseña incorrectos");
            }
        }

        public static bool EsUsuarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int?>(Constantes.USUARIO_LOGUEADO_ID);

            return idUsuario != null && idUsuario.GetType() == typeof(int);
        }
    }
}