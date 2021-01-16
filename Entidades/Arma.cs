using System;

namespace Entidades
{
    public class Arma
    {
        public Arma(string arma1, string arma2, string arma3, string arma4, string arma5)
        {
            Arma1 = arma1;
            Arma2 = arma2;
            Arma3 = arma3;
            Arma4 = arma4;
            Arma5 = arma5;
            Id = new Random().Next();
        }
        public string Arma1 { get; set; }
        public string Arma2 { get; set; }
        public string Arma3 { get; set; }
        public string Arma4 { get; set; }
        public string Arma5 { get; set; }
        public int Id { get; set; }

    }
}
