Ejecucion.Menu.PantallaInicio();
if (!Directory.Exists("guardados"))
    Directory.CreateDirectory("guardados");

var partida = new Ejecucion.Partidas.Partida();
partida = Ejecucion.Menu.EleccionPartida();
if (partida.Equipos.Count() == 0) {

    // CONSUMO DE API
    List<APIPlayer> capitanesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Capitan);
    List<APIPlayer> atacantesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Atacante);
    List<APIPlayer> defensoresAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Defensor);
    List<APITeams> equiposAPI = await ConsumirAPI.ObtenerEquipos();
    equiposAPI.RemoveRange(30, 15);     // ELIMINA LOS EQUIPOS QUE YA NO EXISTEN Y CONSERVA LOS ACTUALES

    // CREACION DE PERSONAJES Y EQUIPOS
    var listaCapitanes = Ejecucion.CrearPersonajes(capitanesAPI, Rol.Capitan);
    var listaAtacantes = Ejecucion.CrearPersonajes(atacantesAPI, Rol.Atacante);
    var listaDefensores = Ejecucion.CrearPersonajes(defensoresAPI, Rol.Defensor);

    // AGREGAR ESTADO DE PARTIDA
    partida.Equipos = Ejecucion.CreacionEquipos.CrearEquipos(listaCapitanes, listaAtacantes, listaDefensores, equiposAPI);
    partida.FaseActual = Fase.Cuartos;
    partida.HistorialPartidos = new Dictionary<Fase, List<Ejecucion.Partidos.Partido>>();

    Ejecucion.Menu.Inicio(partida.Equipos);
}


var equipoUsuario = partida.Equipos[0];

bool jugando;
do
{

    jugando = Ejecucion.Menu.InicioDeFase(partida);
    if (jugando)
    {
        Console.WriteLine("\npresionar espacio para continuar..."); Console.ReadKey();
        Ejecucion.Menu.JugarFase(partida.HistorialPartidos[partida.FaseActual], equipoUsuario);

        Ejecucion.Menu.FinalDeFase(partida);
        
        if (partida.FaseActual == Fase.Terminada)
        {
            Ejecucion.Menu.MensajeCampeon(partida.HistorialPartidos[Fase.Final][0].Ganador);
            Console.WriteLine("\npresionar espacio para cerrar el juego");
            Console.ReadKey();  // MENU JUGAR DE NUEVO
            Console.Clear();
            jugando = false;
        } else
        {
        Console.WriteLine("\npresionar espacio para pasar a la siguiente fase..."); Console.ReadKey();
        }
    }

} while (jugando);