using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Entidades
{
    public class Cochera
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public double SuperficieM2 { get; set; }
        public string Imagen { get; set; }
        public Puntaje Puntaje { get; set; }
        public TipoCochera TipoCochera { get; set; }
    }
}
