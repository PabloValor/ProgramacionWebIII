using System;

namespace AlquilaCocheras.Data.Entidades
{
    public class Puntaje
    {
        public double PuntajeTotal { get; set; }
        public int CantidadVotos { get; set; }

        public double Promedio()
        {
            return Math.Round(PuntajeTotal/CantidadVotos, 1);
        }
    }
}
