
List<Jugador> listaCapitanes = await Jugadores.ObtenerListaJugadores(Rol.Capitan);
List<Jugador> listaDefensores = await Jugadores.ObtenerListaJugadores(Rol.Defensor);
List<Jugador> listaAtacantes = await Jugadores.ObtenerListaJugadores(Rol.Atacante);



Console.ReadKey();