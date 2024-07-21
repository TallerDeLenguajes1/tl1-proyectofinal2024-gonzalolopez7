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

Ejecucion.Menus.Inicio();
Ejecucion.Menus.MenuInicio();

// ELIGE EQUIPO DEL USUARIO Y CREA 7 EQUIPOS
List<Equipo> equipos = Ejecucion.Equipos.CrearEquipos(listaCapitanes, listaAtacantes, listaDefensores, equiposAPI);

// CREACION DICCIONARIO DE PARTIDOS POR FASE
var DiccionarioPartidos = new Dictionary<FasePartido, List<Ejecucion.Partidos.Partido>>()
{
    { FasePartido.CuartoDeFinal, new List<Ejecucion.Partidos.Partido>() },
    { FasePartido.Semifinal, new List<Ejecucion.Partidos.Partido>() },
    { FasePartido.Final, new List<Ejecucion.Partidos.Partido>() }
};

for (int j = 0; j < 8; j+=2)
    DiccionarioPartidos[FasePartido.CuartoDeFinal].Add(new Ejecucion.Partidos.Partido(equipos[j], equipos[j+1], FasePartido.CuartoDeFinal)); 

// JUGAR O SIMULAR CUARTOS DE FINAL
DiccionarioPartidos[FasePartido.CuartoDeFinal][0].JugarPartido();
for (int i = 1; i < 4; i++)
    DiccionarioPartidos[FasePartido.CuartoDeFinal][i].SimularPartido();
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

for (int i = 0; i < 4; i+=2)
{
    var semifinalista1 = DiccionarioPartidos[FasePartido.CuartoDeFinal][i].Ganador;
    var semifinalista2 = DiccionarioPartidos[FasePartido.CuartoDeFinal][i+1].Ganador;
    DiccionarioPartidos[FasePartido.Semifinal].Add(new Ejecucion.Partidos.Partido(semifinalista1, semifinalista2, FasePartido.Semifinal));
}

// JUGAR O SIMULAR SEMIFINALES
if (DiccionarioPartidos[FasePartido.Semifinal][0].Local == equipos[0])
    DiccionarioPartidos[FasePartido.Semifinal][0].JugarPartido();
else
    DiccionarioPartidos[FasePartido.Semifinal][0].SimularPartido();

DiccionarioPartidos[FasePartido.Semifinal][1].SimularPartido();
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~


var finalista1 = DiccionarioPartidos[FasePartido.Semifinal][0].Ganador;
var finalista2 = DiccionarioPartidos[FasePartido.Semifinal][1].Ganador;
DiccionarioPartidos[FasePartido.Final].Add(new Ejecucion.Partidos.Partido(finalista1, finalista2, FasePartido.Final));

// JUGAR O SIMULAR FINAL
if (DiccionarioPartidos[FasePartido.Final][0].Local == equipos[0])
    DiccionarioPartidos[FasePartido.Final][0].JugarPartido();
else
    DiccionarioPartidos[FasePartido.Final][0].SimularPartido();

Console.ReadKey();
