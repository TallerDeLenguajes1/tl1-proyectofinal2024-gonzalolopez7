List<Player> capitanesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Capitan);
List<Player> atacantesAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Atacante);
List<Player> defensoresAPI = await ConsumirAPI.ObtenerListaJugadores(Rol.Defensor);
List<Teams> equiposAPI = await ConsumirAPI.ObtenerEquipos();

equiposAPI.RemoveRange(30, 15);     // ELIMINA LOS EQUIPOS ANTIGUOS Y CONSERVA LOS ACTUALES

// LISTAS DE PERSONAJES SEPARADOS POR ROL Y ORDENADOS POR ID
var listaCapitanes = Ejecucion.CrearPersonajes(capitanesAPI, Rol.Capitan);
var listaAtacantes = Ejecucion.CrearPersonajes(atacantesAPI, Rol.Atacante);
var listaDefensores = Ejecucion.CrearPersonajes(defensoresAPI, Rol.Defensor);

Ejecucion.Menus.Inicio();
Ejecucion.Menus.MenuInicio();

// ELIGE EQUIPO DEL USUARIO Y CREA 7 EQUIPOS
List<Equipo> equipos = Ejecucion.Equipos.CrearEquipos(listaCapitanes, listaAtacantes, listaDefensores, equiposAPI);

Console.ReadKey();
