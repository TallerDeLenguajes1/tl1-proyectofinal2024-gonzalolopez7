Ejecucion.Menu.PantallaInicio();
if (!Directory.Exists("guardados"))
    Directory.CreateDirectory("guardados");

// Elige empezar una nueva partida o carga los datos de un guardado en una instancia "partida"
var partida = Ejecucion.Menu.EleccionPartida();
bool error = false;
if (partida == null) {     
    
    // Si se elige una nueva partida, la instancia partida permanece vacia, por lo tanto entra al if y hace el consumo de la API, creando los personajes y equipos nuevos
    List<APIPlayer> capitanesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Capitan);
    List<APIPlayer> atacantesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Atacante);
    List<APIPlayer> defensoresAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Defensor);
    List<APITeams> equiposAPI = await ConsumirAPI.ObtenerEquipos();
    // Si el consumo de la API presenta una HttpRequestException devuelve las listas nulas

    if (capitanesAPI != null && atacantesAPI != null && defensoresAPI != null && equiposAPI != null)
    {
        // Elimina los equipos antiguos y deja los actuales
        equiposAPI.RemoveRange(30, 15);
        // Creacion de personajes y equipos
        var listaCapitanes = Ejecucion.CrearPersonajes(capitanesAPI, Rol.Capitan);
        var listaAtacantes = Ejecucion.CrearPersonajes(atacantesAPI, Rol.Atacante);
        var listaDefensores = Ejecucion.CrearPersonajes(defensoresAPI, Rol.Defensor);

        // Agrega estado de partida
        partida.Equipos = Ejecucion.CreacionEquipos.CrearEquipos(listaCapitanes, listaAtacantes, listaDefensores, equiposAPI);
        partida.FaseActual = Fase.Cuartos;
        partida.HistorialPartidos = new Dictionary<Fase, List<Ejecucion.Partidos.Partido>>();

        Ejecucion.Menu.Inicio(partida.Equipos);
        
    } else
    {
        Console.WriteLine("\nNo se pudo consumir los datos de la API");
        error = true;
    }
}

if (!error)
{
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
                Ejecucion.Menu.MensajeCampeon(partida.HistorialPartidos[Fase.Final][0].Ganador, equipoUsuario);
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
} else
{
    Console.WriteLine("Ocurrio un error, saliendo del juego...");
}