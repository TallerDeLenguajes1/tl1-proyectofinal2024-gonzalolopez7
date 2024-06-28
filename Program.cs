List<Player> listaCapitanes = await ConsumirAPI.ObtenerListaJugadores(Rol.Capitan);
List<Player> listaAtacantes = await ConsumirAPI.ObtenerListaJugadores(Rol.Atacante);
List<Player> listaDefensores = await ConsumirAPI.ObtenerListaJugadores(Rol.Defensor);
List<Teams> listaEquipos = await ConsumirAPI.ObtenerEquipos();

listaEquipos.RemoveRange(30, 15);

var capitanes = Ejecucion.CrearListaPersonajes(listaCapitanes, Rol.Capitan);
var atacantes = Ejecucion.CrearListaPersonajes(listaAtacantes, Rol.Atacante);
var defensores = Ejecucion.CrearListaPersonajes(listaDefensores, Rol.Defensor);



Ejecucion.Menus.Inicio();
Ejecucion.Menus.MenuInicio();
List<List<Personaje>> equipos = Ejecucion.Equipos.CrearEquipos(capitanes, atacantes, defensores);

Console.ReadKey();
