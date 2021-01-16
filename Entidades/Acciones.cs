using System;

namespace Entidades
{
    public class Acciones
    {
        public Acciones(string accion1, string accion2, string accion3, string accion4, string accion5)
        {
            Accion1 = accion1;
            Accion2 = accion2;
            Accion3 = accion3;
            Accion4 = accion4;
            Accion5 = accion5;

            Id = new Random().Next();

        }
        public string Accion1 { get; set; }
        public string Accion2 { get; set; }
        public string Accion3 { get; set; }
        public string Accion4 { get; set; }
        public string Accion5 { get; set; }


        public int Id { get; set; }



    }
}

