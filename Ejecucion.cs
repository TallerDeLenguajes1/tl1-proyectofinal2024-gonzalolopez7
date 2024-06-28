using System.Net.NetworkInformation;

public static class Ejecucion
{
    
    public static List<Personaje> CrearListaPersonajes(List<Player> jugadores, Rol rol) {
        var listaPersonajes = new List<Personaje>();

        double tiro, creacion, defensaPerimetro, defensaInterior, promedio;

        if (rol == Rol.Capitan)
        {
            foreach (var jugador in jugadores)
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

                listaPersonajes.Add(new Personaje(
                    new Datos(
                        jugador.Id,
                        jugador.FirstName,
                        jugador.LastName,
                        jugador.JerseyNumber,
                        jugador.Country,
                        new Equipo(
                            jugador.Team.FullName,
                            jugador.Team.Abbreviation
                        )
                    ),
                    new Estadisticas(double.Round(tiro, 1), double.Round(creacion, 1), double.Round(defensaPerimetro, 1), double.Round(defensaInterior, 1), double.Round(promedio, 1))
                ));
                
            }
        }
        if (rol == Rol.Atacante)
        {
            foreach (var jugador in jugadores)
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

                listaPersonajes.Add(new Personaje(
                    new Datos(
                        jugador.Id,
                        jugador.FirstName,
                        jugador.LastName,
                        jugador.JerseyNumber,
                        jugador.Country,
                        new Equipo(
                            jugador.Team.FullName,
                            jugador.Team.Abbreviation
                        )
                    ),
                    new Estadisticas(double.Round(tiro, 1), double.Round(creacion, 1), double.Round(defensaPerimetro, 1), double.Round(defensaInterior, 1), double.Round(promedio, 1))
                ));

            }
        }
        if (rol == Rol.Defensor)
        {
            foreach (var jugador in jugadores)
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

                listaPersonajes.Add(new Personaje(
                    new Datos(
                        jugador.Id,
                        jugador.FirstName,
                        jugador.LastName,
                        jugador.JerseyNumber,
                        jugador.Country,
                        new Equipo(
                            jugador.Team.FullName,
                            jugador.Team.Abbreviation
                        )
                    ),
                    new Estadisticas(double.Round(tiro, 1), double.Round(creacion, 1), double.Round(defensaPerimetro, 1), double.Round(defensaInterior, 1), double.Round(promedio, 1))
                ));

            }
        }

        return listaPersonajes;
    }

    public static class Menus
    {
        
        public static void Inicio() {

            Console.WriteLine("NOMBRE JUEGO");

        }

        public static int MenuInicio() {
            int opcion; bool b = true;

            do
            {
                
                Console.WriteLine("1. Comenzar juego");
                Console.WriteLine("2. Salir");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 0 || opcion > 3 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }

            } while (!b);

            return opcion;
        }

        public static Teams MenuElegirEquipo(List<Teams> equipos) {
            int opcion; bool b = true;

            for (int i = 0; i < equipos.Count(); i++)
                Console.WriteLine($"{i+1}. {equipos[i].Nombre} - {equipos[i].Abreviacion}");

            do
            {
                
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 8 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
                
            } while (!b);

            return equipos[opcion-1];
        }

    }

    public static class Equipos
    {

        public static List<List<Personaje>> CrearEquipos(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores) {

            var equipos = new List<List<Personaje>>(8){
                ElegirEquipo(capitanes, atacantes, defensores)
            };

            var idUsados = new List<int>();
            for (int i = 0; i < 3; i++)
                idUsados.Add(equipos[0][i].Datos.Id);

            for (int i = 1; i < 8; i++)
            {
                equipos.Add(GenerarEquipo(idUsados, capitanes, atacantes, defensores));
            }
            return equipos;
        }
        
        private static List<Personaje> ElegirEquipo(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores) {
            var equipoUsuario = new List<Personaje>();
            int opcion; bool b = true;

            Console.WriteLine("\tSELECCIONAR CAPITAN");
            mostrarPersonajes(capitanes);
            do
            {
                
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 8 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
                
            } while (!b);
            equipoUsuario.Add(capitanes.ElementAt(opcion-1));

            Console.WriteLine("\tSELECCIONAR ATACANTE");
            mostrarPersonajes(atacantes);
            do
            {
                
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 8 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
                
            } while (!b);
            equipoUsuario.Add(atacantes.ElementAt(opcion-1));

            Console.WriteLine("\tSELECCIONAR DEFENSORES");
            mostrarPersonajes(defensores);
            do
            {
                
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 8 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
                
            } while (!b);
            equipoUsuario.Add(defensores.ElementAt(opcion-1));

            return equipoUsuario;
        }

        private static void mostrarPersonajes(List<Personaje> listaPersonajes) {

            for (int i = 0; i < listaPersonajes.Count(); i++)
            {

                Console.WriteLine($"\n{i+1}.\t\b\bDATOS:");
                Console.WriteLine($" {listaPersonajes[i].Datos.Nombre} {listaPersonajes[i].Datos.Apellido} - {listaPersonajes[i].Datos.Numero}");
                Console.WriteLine($" {listaPersonajes[i].Datos.Equipo.Nombre} - {listaPersonajes[i].Datos.Equipo.Abreviacion}");
                Console.WriteLine("\tESTADISTICAS:");
                Console.WriteLine($"- Tiro: {listaPersonajes[i].Estadisticas.Tiro} - Creacion: {listaPersonajes[i].Estadisticas.Creacion}");
                Console.WriteLine($"- Defensa Perimetro: {listaPersonajes[i].Estadisticas.DefensaPerimetro} - Defensa Interior: {listaPersonajes[i].Estadisticas.DefensaInterior}");
                Console.WriteLine($"- PROMEDIO: {listaPersonajes[i].Estadisticas.Promedio}");

            }

        }

        private static List<Personaje> GenerarEquipo(List<int> idUsados, List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores) {
            
            var nuevoEquipo = new List<Personaje>(){
                ElegirPersonajeAleatorio(idUsados, capitanes),
                ElegirPersonajeAleatorio(idUsados, atacantes),
                ElegirPersonajeAleatorio(idUsados, defensores)
            };

            return nuevoEquipo;
        }

        private static Personaje ElegirPersonajeAleatorio(List<int> idUsados, List<Personaje> personajes) {

            var random = new Random();
            int valor;
            bool b;
            do                                                          // BUSCAR UN PERSONAJE ALEATORIO EN LA LISTA
            {
                b = false;
                valor = random.Next(0, 8);
                foreach (var id in idUsados)
                    if (id == personajes[valor].Datos.Id)                // VERIFICA QUE EL ID NO COINCIDA CON EL ID DE UN JUGADOR YA ASIGNADO A OTRO EQUIPO
                        b = true;

            } while (b);

            idUsados.Add(personajes[valor].Datos.Id);
            return personajes[valor];
        }

    }

}
