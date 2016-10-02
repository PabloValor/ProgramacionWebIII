using System.Collections.Generic;

namespace AlquilaCocheras.Data.Entidades
{
    public class Propietario : Usuario
    {
        public List<Cochera> Cocheras { get; set; }
    }
}
