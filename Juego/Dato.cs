using Interfaces;
using Entidades;
namespace Dato
{
    public class Datos
    {
        IPersistencia persistencia;
        IPersistencia2 persistenciados;
        IPersistencia3 persistenciatres;
        IPersistencia4 persistenciacuatro;
        IPersistencia5 persistenciacinco;



        public Datos(IPersistencia persistencia, IPersistencia2 persistenciados, IPersistencia3 persistenciatres, IPersistencia4 persistenciacuatro, IPersistencia5 persistenciacinco)
        {
            this.persistencia = persistencia;
            this.persistenciados = persistenciados;
            this.persistenciatres = persistenciatres;
            this.persistenciacuatro = persistenciacuatro;
            this.persistenciacinco = persistenciacinco;



        }
        public string Registar(Jugador jugador, Arma arma, Acciones acciones)
        {


            persistencia.Grabar(jugador);
            persistencia.Grabar(arma);
            persistencia.Grabar(acciones);

            persistenciados.Grabar(jugador);
            persistenciados.Grabar(arma);
            persistenciados.Grabar(acciones);

            persistenciatres.Grabar(jugador);
            persistenciatres.Grabar(arma);
            persistenciatres.Grabar(acciones);

            persistenciacuatro.Grabar(jugador);
            persistenciacuatro.Grabar(arma);
            persistenciacuatro.Grabar(acciones);

            persistenciacinco.Grabar(jugador);
            persistenciacinco.Grabar(arma);
            persistenciacinco.Grabar(acciones);

            persistencia.Grabar(new AccionDeJugador { JugadorId = jugador.Id, AccionId = arma.Id });
            return string.Format("El estudiante {0} {1} {2}"
                , jugador.Player1
                , arma.Arma1
                , acciones.Accion1);

        }
    }
}
