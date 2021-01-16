using Entidades;
using Interfaces;
using System;
using Dato;
using PersistenciaUno;
using PersistenciaDos;
using PersistenciaTres;
using PersistenciaCuatro;
using PersistenciaCinco;
using LightInject;
using Di.LightInject;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...............La guerra inicia................");

            var container = new LightInject.ServiceContainer();

            container.Register<IPersistencia, Persistencia>();
            var instanceUno = container.GetInstance<IPersistencia>();

            container.Register<IPersistencia2, Persistencia2>();
            var instanceDos = container.GetInstance<IPersistencia2>();

            container.Register<IPersistencia3, Persistencia3>();
            var instanceTres = container.GetInstance<IPersistencia3>();

            container.Register<IPersistencia4, Persistencia4>();
            var instanceCuatro = container.GetInstance<IPersistencia4>();

            container.Register<IPersistencia5, Persistencia5>();
            var instanceCinco = container.GetInstance<IPersistencia5>();



            Datos dato = new Datos(instanceUno, instanceDos, instanceTres, instanceCuatro, instanceCinco);
            Jugador jugador = new Jugador("Player1", "Player2", "Player3", "Player4", "Player5");

            Arma arma = new Arma("Arco y flecha", "Espada", "Escudo", "Martillo", "Mazo");

            Acciones acciones = new Acciones("Flechar", "Apuñalar", "Taclear", "lanzar", "Aplastar");

            dato.Registar(jugador, arma, acciones);

        }

    }
}

