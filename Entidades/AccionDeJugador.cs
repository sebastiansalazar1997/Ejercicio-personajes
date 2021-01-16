using System;

namespace Entidades
{
    public class AccionDeJugador
    {
        public int JugadorId { get; set; }

        public int AccionId { get; set; }

        public int Id { get; set; } = new Random().Next();

    }
}
