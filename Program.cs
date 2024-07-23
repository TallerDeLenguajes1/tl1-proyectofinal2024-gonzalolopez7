using System.Text.Json;

// ~~~~ DATOS ONLINE ~~~~~

    /*

        List<APIPlayer> capitanesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Capitan);
        List<APIPlayer> atacantesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Atacante);
        List<APIPlayer> defensoresAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Defensor);
        List<Teams> equiposAPI = await ConsumirAPI.ObtenerEquipos();

        equiposAPI.RemoveRange(30, 15);     // ELIMINA LOS EQUIPOS ANTIGUOS Y CONSERVA LOS ACTUALES

    */

// ~~~~~~~~~~~~~~~~~~~~~~~

// ~~~~ DATOS OFFLINE ~~~~

    /*  ESCRIBIR LISTAS EN JSON

        var options = new JsonSerializerOptions
            {
                WriteIndented = true // Para un JSON más legible
            };

        File.WriteAllText("capitanesOffline.json", JsonSerializer.Serialize(capitanesAPI, options));
        File.WriteAllText("atacantesOffline.json", JsonSerializer.Serialize(atacantesAPI, options));
        File.WriteAllText("defensoresOffline.json", JsonSerializer.Serialize(defensoresAPI, options));
        File.WriteAllText("equiposOffline.json", JsonSerializer.Serialize(equiposAPI, options));

    */

string capitanesAPIString = File.ReadAllText("capitanesOffline.json");
string atacantesAPIString = File.ReadAllText("atacantesOffline.json");
string defensoresAPIString = File.ReadAllText("defensoresOffline.json");
string equiposAPIString = File.ReadAllText("equiposOffline.json");
List<APIPlayers> capitanesAPI = JsonSerializer.Deserialize<List<APIPlayers>>(capitanesAPIString);
List<APIPlayers> atacantesAPI = JsonSerializer.Deserialize<List<APIPlayers>>(atacantesAPIString);
List<APIPlayers> defensoresAPI = JsonSerializer.Deserialize<List<APIPlayers>>(defensoresAPIString);
List<APITeams> equiposAPI = JsonSerializer.Deserialize<List<APITeams>>(equiposAPIString);





// ~~~~~~~~~~~~~~~~~~~~~~~

// LISTAS DE PERSONAJES SEPARADOS POR ROL Y ORDENADOS POR ID
var listaCapitanes = Ejecucion.CrearPersonajes(capitanesAPI, Rol.Capitan);
var listaAtacantes = Ejecucion.CrearPersonajes(atacantesAPI, Rol.Atacante);
var listaDefensores = Ejecucion.CrearPersonajes(defensoresAPI, Rol.Defensor);

Ejecucion.Menu.NombreJuego();
Console.WriteLine("\npresionar espacio para continuar..."); Console.ReadKey();
List<Equipo> equipos = Ejecucion.CreacionEquipos.CrearEquipos(listaCapitanes, listaAtacantes, listaDefensores, equiposAPI);

Ejecucion.Menu.Inicio(equipos);

// ASIGNACION PARTIDOS DE CUARTOS DE FINAL
var DiccPartidos = Ejecucion.CrearCrucesCuartos(equipos);
Ejecucion.Menu.Cruces(Fase.Cuartos, DiccPartidos[Fase.Cuartos]);

// JUGAR O SIMULAR PARTIDOS DE CUARTOS DE FINAL
DiccPartidos[Fase.Cuartos][0].Jugar();
for (int i = 1; i < 4; i++)
    DiccPartidos[Fase.Cuartos][i].Simular();


Console.WriteLine("presionar espacio para continuar..."); Console.ReadKey();
// MOSTRAR PARTIDOS DE CUARTOS DE FINAL
Ejecucion.Menu.ResultadosFase(DiccPartidos[Fase.Cuartos]);
Console.WriteLine("presionar espacio para pasar a la siguiente fase..."); Console.ReadKey();

// SEMIFINALES

// ASIGNACION PARTIDOS DE SEMIFINALES
Ejecucion.CrearCrucesSemis(DiccPartidos);
Ejecucion.Menu.Cruces(Fase.Semis, DiccPartidos[Fase.Semis]);

// JUGAR O SIMULAR SEMIFINALES
if (DiccPartidos[Fase.Semis][0].Local == equipos[0])
    DiccPartidos[Fase.Semis][0].Jugar();
else
    DiccPartidos[Fase.Semis][0].Simular();

DiccPartidos[Fase.Semis][1].Simular();


Console.WriteLine("presione espacio para continuar..."); Console.ReadKey();
// MOSTRAR PARTIDOS DE SEMIFINALES
Ejecucion.Menu.ResultadosFase(DiccPartidos[Fase.Semis]);
Console.WriteLine("presionar espacio para pasar a la siguiente fase..."); Console.ReadKey();

// FINAL

// ASIGNACION PARTIDO FINAL
Ejecucion.CrearFinal(DiccPartidos);
Ejecucion.Menu.Cruces(Fase.Final, DiccPartidos[Fase.Final]);

// JUGAR O SIMULAR FINAL
if (DiccPartidos[Fase.Final][0].Local == equipos[0])
    DiccPartidos[Fase.Final][0].Jugar();
else
{
    DiccPartidos[Fase.Final][0].Simular();
    Ejecucion.Menu.ResultadosFase(DiccPartidos[Fase.Final]);
}

Ejecucion.Menu.MensajeCampeon(DiccPartidos[Fase.Final][0].Ganador);
Console.WriteLine("presionar espacio para cerrar juego");
Console.ReadKey();
