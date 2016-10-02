using System.Collections.Generic;

namespace AlquilaCocheras.Data.Entidades
{
    class Propietario : Usuario
    {
        public List<Cochera> Cocheras { get; set; }
    }
}
