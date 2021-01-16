using System;

namespace Entidades
{
    public class Jugador
    {
        public Jugador(string player1, string player2, string player3, string player4, string player5)
        {
            Player1 = player1;
            Player2 = player2;
            Player3 = player3;
            Player4 = player4;
            Player5 = player5;

            Id = new Random().Next();

        }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Player3 { get; set; }
        public string Player4 { get; set; }
        public string Player5 { get; set; }
        public int Id { get; set; }



    }
}
