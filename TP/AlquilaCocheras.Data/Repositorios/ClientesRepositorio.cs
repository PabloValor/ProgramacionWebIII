using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ClientesRepositorio
    {
        #region Miembros

        private readonly EstacionaloEntities _db;

        #endregion

        #region Constructores

        public ClientesRepositorio()
        {
            _db = new EstacionaloEntities();
        }
        #endregion

        #region Métodos Publicos

        public Cliente ObtenerClientePorId(int id)
        {

            var cliente = (from c in _db.Cliente
                         join u in _db.Usuario on c.IdUsuario equals u.Id
                         join tp in _db.TipoPerfilUsuario on u.IdTipoPerfilUsuario equals tp.Id
                         where u.Id == id && tp.Id == (int)Enums.TipoPerfilUsuario.Cliente
                         select new { c }).First().c;

            return cliente;
        }

        #endregion
    }
}
