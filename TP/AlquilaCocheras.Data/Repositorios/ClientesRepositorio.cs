using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ClientesRepositorio
    {
        #region Miembros

        private readonly TP_20162CEntities _db;

        #endregion

        #region Constructores

        public ClientesRepositorio()
        {
            _db = new TP_20162CEntities();
        }
        #endregion

        #region Métodos Publicos

        public Usuarios ObtenerClientePorId(int id)
        {
            var cliente =
                _db.Usuarios.FirstOrDefault(u => u.IdUsuario == id && u.Perfil == (int)Enums.TipoPerfilUsuario.Cliente);

            return cliente;
        }

        #endregion
    }
}
