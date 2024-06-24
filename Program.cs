
using System.Text.Json;

List<Jugador> listaCapitanes = await Jugadores.ObtenerListaJugadores(Rol.Capitan);
List<Jugador> listaAtacantes = await Jugadores.ObtenerListaJugadores(Rol.Atacante);
List<Jugador> listaDefensores = await Jugadores.ObtenerListaJugadores(Rol.Defensor);

var capitanes = new List<Personaje>();
var atacantes = new List<Personaje>();
var defensores = new List<Personaje>();
double tiro, creacion, defensaPerimetro, defensaInterior, promedio;

foreach (var jugador in listaCapitanes)
{

    tiro = (4 * jugador.Stats.Fg + 3 * jugador.Stats.Fg3 + 1.6 * jugador.Stats.Ft) * 1.8;
    if (tiro < 8)
        tiro = 8;
    if (tiro > 9.5)
        tiro = 9.5;

    creacion = jugador.Stats.Ast / jugador.Stats.To * 3.5;
    if (creacion < 8)
        creacion = 8;
    if (creacion > 9.5)
        creacion = 9.5;

    defensaPerimetro = jugador.Stats.Stl * 6;
    if (defensaPerimetro < 6.5)
        defensaPerimetro = 6.5;
    if (defensaPerimetro > 9)
        defensaPerimetro = 9;

    defensaInterior = 0.7 * jugador.Stats.Dreb + 0.7 * jugador.Stats.Blk;
    if (defensaInterior < 4)
        defensaInterior = 4;
    if (defensaInterior > 7)
        defensaInterior = 7;
       
    promedio = ((tiro + creacion + defensaPerimetro + defensaInterior) / 4) + 2;

    capitanes.Add(new Personaje(
        new Datos(
            jugador.FirstName,
            jugador.LastName,
            jugador.JerseyNumber,
            jugador.Country,
            new Equipo(
                jugador.Team.FullName,
                jugador.Team.Abbreviation
            )
        ),
        new Estadisticas(double.Round(tiro, 2), double.Round(creacion, 2), double.Round(defensaPerimetro, 2), double.Round(defensaInterior, 2), double.Round(promedio, 2))
    ));
    
}

foreach (var jugador in listaAtacantes)
{

    tiro = (5 * jugador.Stats.Fg + 3 * jugador.Stats.Fg3 + 1.8 * jugador.Stats.Ft) * 1.8;
    if (tiro < 8.5)
        tiro = 8.5;
    if (tiro > 10)
        tiro = 10;

    creacion = jugador.Stats.Ast / jugador.Stats.To * 3.5;
    if (creacion < 7)
        creacion = 7;
    if (creacion > 9)
        creacion = 9;

    defensaPerimetro = jugador.Stats.Stl * 7;
    if (defensaPerimetro < 6.5)
        defensaPerimetro = 6.5;
    if (defensaPerimetro > 9.5)
        defensaPerimetro = 9.5;

    defensaInterior = 0.7 * jugador.Stats.Dreb + 0.7 * jugador.Stats.Blk;
    if (defensaInterior < 4)
        defensaInterior = 4;
    if (defensaInterior > 5)
        defensaInterior = 5;
       
    promedio = ((tiro + creacion + defensaPerimetro + defensaInterior) / 4) + 2;

    atacantes.Add(new Personaje(
        new Datos(
            jugador.FirstName,
            jugador.LastName,
            jugador.JerseyNumber,
            jugador.Country,
            new Equipo(
                jugador.Team.FullName,
                jugador.Team.Abbreviation
            )
        ),
        new Estadisticas(double.Round(tiro, 2), double.Round(creacion, 2), double.Round(defensaPerimetro, 2), double.Round(defensaInterior, 2), double.Round(promedio, 2))
    ));

}

foreach (var jugador in listaDefensores)
{

    tiro = (4 * jugador.Stats.Fg + 3 * jugador.Stats.Fg3 + 1.6 * jugador.Stats.Ft) * 1.6;
    if (tiro < 6.5)
        tiro = 6.5;
    if (tiro > 7.5)
        tiro = 7.5;

    creacion = jugador.Stats.Ast / jugador.Stats.To * 3.5;
    if (creacion < 5)
        creacion = 5;
    if (creacion > 6.5)
        creacion = 6.5;

    defensaPerimetro = jugador.Stats.Stl * 5;
    if (defensaPerimetro < 5)
        defensaPerimetro = 5;
    if (defensaPerimetro > 6.5)
        defensaPerimetro = 6.5;

    defensaInterior = (0.6 * jugador.Stats.Dreb + 0.6 * jugador.Stats.Blk) * 2;
    if (defensaInterior < 8)
        defensaInterior = 8;
    if (defensaInterior > 10)
        defensaInterior = 10;

    promedio = ((tiro + creacion + defensaPerimetro + defensaInterior) / 4) + 1.5;

    defensores.Add(new Personaje(
        new Datos(
            jugador.FirstName,
            jugador.LastName,
            jugador.JerseyNumber,
            jugador.Country,
            new Equipo(
                jugador.Team.FullName,
                jugador.Team.Abbreviation
            )
        ),
        new Estadisticas(double.Round(tiro, 2), double.Round(creacion, 2), double.Round(defensaPerimetro, 2), double.Round(defensaInterior, 2), double.Round(promedio, 2))
    ));

}

Console.ReadKey();
