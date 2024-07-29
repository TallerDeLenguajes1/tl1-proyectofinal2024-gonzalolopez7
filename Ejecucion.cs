public static class Ejecucion
{
    
    public static List<Personaje> CrearPersonajes(List<APIPlayers> jugadores, Rol rol) {
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
                        new DatosEquipo(
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
                        new DatosEquipo(
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
                        new DatosEquipo(
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

    public static class Menu
    {
        
        public static void NombreJuego() {

            Console.Title = "NBA API";
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~   ~~  ~~      ~~~~     ~~~~~~     ~~~      ~~~       ~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~~    ~  ~~  ~~~  ~~       ~~~~       ~~  ~~~  ~~~~   ~~~~");
            Console.WriteLine("~~       ~~      ~~~  ~~~  ~~~~  ~~~  ~~      ~~~~~   ~~~~");
            Console.WriteLine("~~  ~    ~~  ~~~  ~~       ~~~~       ~~  ~~~~~~~~~   ~~~~");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~  ~~   ~~      ~~~  ~~~  ~~~~  ~~~  ~~  ~~~~~~~       ~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Gray;


        }

        public static void Inicio(List<Equipo> listaEquipos) {
            int opcion; bool b;
            
            Console.Title = "NBA API";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ MENU ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("1. Comenzar partida");
            Console.WriteLine("2. Mostrar lista de equipos");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 2 || !b)
                {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
            } while (!b);

            if (opcion == 2)
                Formaciones(listaEquipos);

        }

        private static void Formaciones(List<Equipo> listaEquipos) {

            Console.Clear();
            for (int i = 0; i < listaEquipos.Count(); i+=2)
            {
                Console.WriteLine($"\n{i+1}. {listaEquipos[i].Nombre} ({listaEquipos[i].Abreviacion})");
                Console.WriteLine($"~ Atacante: {listaEquipos[i].Atacante.Datos.Nombre}");
                Console.WriteLine($"~ Capitan: {listaEquipos[i].Capitan.Datos.Nombre}");
                Console.WriteLine($"~ Defensor: {listaEquipos[i].Defensor.Datos.Nombre}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top - 4);
                Console.Write($"{i+2}. {listaEquipos[i+1].Nombre} ({listaEquipos[i+1].Abreviacion})");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ Atacante: {listaEquipos[i+1].Atacante.Datos.Nombre}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ Capitan: {listaEquipos[i+1].Capitan.Datos.Nombre}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ Defensor: {listaEquipos[i+1].Defensor.Datos.Nombre}");
                Console.SetCursorPosition(0, Console.GetCursorPosition().Top + 1);
                Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top);
                Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

            int opcion ; bool b; bool mostrarOtroEquipo;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ MENU ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("1. Comenzar partida");
            Console.WriteLine("2. Mostrar informacion de equipo");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 2 || !b)
                {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }

            } while (!b);

            if (opcion == 2)
            {
                
                do
                {
                    do
                    {

                        Console.WriteLine("\nNumero de equipo:");
                        b = int.TryParse(Console.ReadLine(), out opcion);
                        if (opcion < 1 || opcion > listaEquipos.Count() || !b)
                        {
                            Console.WriteLine("Opcion no valida, ingresar nuevamente");
                            b = false;
                        }

                    } while (!b);

                    InformacionEquipo(listaEquipos[opcion-1]);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("1. Comenzar partida");
                    Console.WriteLine("2. Mostrar informacion de otro equipo");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    do
                    {

                        Console.WriteLine("\nSeleccion:");
                        b = int.TryParse(Console.ReadLine(), out opcion);
                        if (opcion < 1 || opcion > 2 || !b)
                        {
                            Console.WriteLine("Opcion no valida, ingresar nuevamente");
                            b = false;
                        }

                    } while (!b);

                    if (opcion == 2)
                        mostrarOtroEquipo = true;
                    else
                        mostrarOtroEquipo = false;

                } while (mostrarOtroEquipo);
            }

        }

        private static void InformacionEquipo(Equipo equipo) {
            
            Console.WriteLine($"\n~~~~ {equipo.Nombre.ToUpper()} ({equipo.Abreviacion}) ~~~~");
            Console.WriteLine($"~ Capitan: {equipo.Capitan.Datos.Nombre}");
            Console.WriteLine($"~ Atacante: {equipo.Atacante.Datos.Nombre}");
            Console.WriteLine($"~ Defensor: {equipo.Defensor.Datos.Nombre}");
            Console.WriteLine($"~~ ESTADISTICAS ~~");
            Console.WriteLine($"~ Tiro: {equipo.Estadisticas.Tiro} ~ Creacion: {equipo.Estadisticas.Creacion}");
            Console.WriteLine($"~ Defensa Perimetro: {equipo.Estadisticas.DefensaPerimetro} ~ Defensa Interior: {equipo.Estadisticas.DefensaInterior}");

        }

        private static void InformacionPersonaje(Personaje personaje, string rol) {

            Console.WriteLine($"\n~~~~ {rol} ~~~~");
            Console.WriteLine($"~~~~ {personaje.Datos.Nombre.ToUpper()} ({personaje.Datos.Numero}) ~~~~");
            Console.WriteLine($"~ Tiro: {personaje.Estadisticas.Tiro} ~ Creacion: {personaje.Estadisticas.Creacion}");
            Console.WriteLine($"~ Defensa Perimetro: {personaje.Estadisticas.DefensaPerimetro} ~ Defensa Interior: {personaje.Estadisticas.DefensaInterior}");
            Console.WriteLine($"~ PROMEDIO: {personaje.Estadisticas.Promedio}");

        }

        public static void Rival(Equipo equipo) {
            int opcion; bool b;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Iniciar partido");
            Console.WriteLine("2. Mostrar informacion de equipo rival");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;


            do
            {
                Console.WriteLine("\nSeleccion:");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 2 || !b)
                {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }

            } while (!b);

            if (opcion == 2)
            {
                InformacionEquipo(equipo);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. Iniciar partido");
                Console.WriteLine("2. Mostrar informacion de personajes");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                do
                {
                    Console.WriteLine("\nSeleccion:");
                    b = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion < 1 || opcion > 2 || !b)
                    {
                        Console.WriteLine("Opcion no valida, ingresar nuevamente");
                        b = false;
                    }
                    
                } while (!b);

                if (opcion == 2)
                {
                    InformacionPersonaje(equipo.Capitan, "CAPITAN");
                    InformacionPersonaje(equipo.Atacante, "ATACANTE");
                    InformacionPersonaje(equipo.Defensor, "DEFENSOR");
                }

            }

        }

        public static void Cruces(Fase fase, List<Partidos.Partido> listapartidos) {

            string stringFase;

            if (fase == Fase.Cuartos)
                stringFase = "CUARTOS DE FINAL";
            else if (fase == Fase.Semis)
                stringFase = "SEMIFINALES";
            else /* (fase == FasePartido.Final) */
                stringFase = "FINAL";

            Console.Clear();
            Console.WriteLine($"\n\n\n~~~~ {stringFase} ~~~~");
            foreach (var partido in listapartidos)
                Console.WriteLine($"~~ {partido.Local.Abreviacion} vs {partido.Visitante.Abreviacion} ~~");

        }

        public static void ResultadosFase(List<Partidos.Partido> listaPartidos) {

            Console.WriteLine("\n~~~~ RESULTADOS ~~~~");

            foreach (var partido in listaPartidos)
            {
                Console.WriteLine($"~~ {partido.Local.Abreviacion} [{partido.PtosLocal}] - [{partido.PtosVisitante}] {partido.Visitante.Abreviacion} ~~");
            }

        }

        public static void MensajeCampeon(Equipo equipoCampeon) {

            string nombreMayus = equipoCampeon.Nombre.ToUpper();

            Console.WriteLine("\n");
            
            Console.WriteLine($"~~~~~~~~~~ {nombreMayus} CAMPEONES DE LA NBA ~~~~~~~~~~");
            Console.WriteLine("\n");

        }

    }

    public static class CreacionEquipos
    {

        public static List<Equipo> CrearEquipos(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores, List<APITeams> equiposAPI) {

            // inicializo una lista de instancias tipo Equipo con una capacidad inicial de 8 elementos
            var equipos = new List<Equipo>(8){
                ElegirEquipo(capitanes, atacantes, defensores)
            };

            Random random = new Random();
            var capitanesDesordenados = capitanes.OrderBy(x => random.Next()).ToList();
            var atacantesDesordenados = atacantes.OrderBy(x => random.Next()).ToList();
            var defensoresDesordenados = defensores.OrderBy(x => random.Next()).ToList();
            capitanesDesordenados.Remove(equipos[0].Capitan);
            atacantesDesordenados.Remove(equipos[0].Atacante);
            defensoresDesordenados.Remove(equipos[0].Defensor);

            for (int i = 0; i < 7; i++)
            {
                var nuevoEquipo = new Equipo(
                    capitanesDesordenados[i],
                    atacantesDesordenados[i],
                    defensoresDesordenados[i]
                );
                
                equipos.Add(nuevoEquipo);
            }

            AsignarNombreEquipos(equipos, equiposAPI);

            return equipos;
        }
        
        private static Equipo ElegirEquipo(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores) {
            var capitan = new Personaje();
            var atacante = new Personaje();
            var defensor = new Personaje();
            int opcion; bool b = true;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ SELECCIONAR CAPITAN ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            capitan = capitanes.ElementAt(opcion-1);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ SELECCIONAR ATACANTE ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            atacante = atacantes.ElementAt(opcion-1);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ SELECCIONAR DEFENSOR ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            defensor = defensores.ElementAt(opcion-1);

            var equipoUsuario = new Equipo(
                capitan,
                atacante,
                defensor
            );

            return equipoUsuario;
        }

        private static void mostrarPersonajes(List<Personaje> listaPersonajes) {

            for (int i = 0; i < listaPersonajes.Count(); i+=2)
            {

                Console.WriteLine($"\n{i+1}.");
                Console.WriteLine("~~ DATOS ~~");
                Console.WriteLine($"~ {listaPersonajes[i].Datos.Nombre} ~ {listaPersonajes[i].Datos.Numero}");
                Console.WriteLine($"~ {listaPersonajes[i].Datos.Equipo.Nombre} ~ {listaPersonajes[i].Datos.Equipo.Abreviacion}");
                Console.WriteLine("~~ ESTADISTICAS ~~");
                Console.WriteLine($"~ Tiro: {listaPersonajes[i].Estadisticas.Tiro} ~ Creacion: {listaPersonajes[i].Estadisticas.Creacion}");
                Console.WriteLine($"~ Defensa Perimetro: {listaPersonajes[i].Estadisticas.DefensaPerimetro} ~ Defensa Interior: {listaPersonajes[i].Estadisticas.DefensaInterior}");
                Console.WriteLine($"~ PROMEDIO: {listaPersonajes[i].Estadisticas.Promedio}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top - 8);
                Console.Write($"{i+2}.");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write("~~ DATOS ~~");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ {listaPersonajes[i+1].Datos.Nombre} ~ {listaPersonajes[i+1].Datos.Numero}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ {listaPersonajes[i+1].Datos.Equipo.Nombre} ~ {listaPersonajes[i+1].Datos.Equipo.Abreviacion}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write("~~ ESTADISTICAS ~~");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ Tiro: {listaPersonajes[i+1].Estadisticas.Tiro} ~ Creacion: {listaPersonajes[i+1].Estadisticas.Creacion}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ Defensa Perimetro: {listaPersonajes[i+1].Estadisticas.DefensaPerimetro} ~ Defensa Interior: {listaPersonajes[i+1].Estadisticas.DefensaInterior}");
                Console.SetCursorPosition(70, Console.GetCursorPosition().Top + 1);
                Console.Write($"~ PROMEDIO: {listaPersonajes[i+1].Estadisticas.Promedio}");
                Console.WriteLine("\n");
            }

        }

        private static APITeams ElegirNombreEquipo(List<APITeams> equipos) {
            int opcion; bool b = true;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~ SELECCIONAR EQUIPO ~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < equipos.Count(); i++)
                Console.WriteLine($"{i+1}. {equipos[i].Fullname} - {equipos[i].Abbreviation}");

            do
            {
                
                Console.WriteLine("\nSeleccion: ");
                b = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 30 || !b) {
                    Console.WriteLine("Opcion no valida, ingresar nuevamente");
                    b = false;
                }
                
            } while (!b);

            return equipos[opcion-1];
        }

        private static void AsignarNombreEquipos(List<Equipo> equipos, List<APITeams> equiposAPI) {

            var equipoUsuario = ElegirNombreEquipo(equiposAPI);
            equipos[0].Nombre = equipoUsuario.Fullname;
            equipos[0].Abreviacion = equipoUsuario.Abbreviation;

            Random random = new Random();
            var equiposAPIDesordenados = equiposAPI.OrderBy(x => random.Next()).ToList();
            equiposAPIDesordenados.Remove(equipoUsuario);

            for (int i = 1; i < 8; i++)
            {
                
                equipos[i].Nombre = equiposAPIDesordenados[i-1].Fullname;
                equipos[i].Abreviacion = equiposAPIDesordenados[i-1].Abbreviation;
                equiposAPIDesordenados.RemoveAt(i-1);

            }

        }

    }

    public static class Partidos {

        public class Partido
        {

            Equipo local;
            Equipo visitante;
            Fase fase;
            int ptosLocal;
            int ptosVisitante;
            Equipo ganador;

            public Partido(Equipo local, Equipo visitante, Fase fase)
            {
                this.local = local;
                this.visitante = visitante;
                this.fase = fase;
                ptosLocal = 0;
                ptosVisitante = 0;
            }

            public Equipo Local { get => local; set => local = value; }
            public Equipo Visitante { get => visitante; set => visitante = value; }
            public int PtosLocal { get => ptosLocal; }
            public int PtosVisitante { get => ptosVisitante; }
            public Fase Fase { get => fase; }
            public Equipo Ganador { get => ganador; }

            public void Jugar() {

                Console.Clear();
                Console.WriteLine("\n\n~~~~ SIGUIENTE PARTIDO ~~~~");
                Console.WriteLine($"~~ LOCAL: {local.Nombre} ({local.Abreviacion}) - VISITANTE: {visitante.Nombre} ({visitante.Abreviacion}) ~~");
                Menu.Rival(visitante);
                Console.WriteLine("\npresionar espacio para comenzar el partido..."); Console.ReadKey();

                JugarTiempoRegular();
                if (ptosLocal > ptosVisitante)
                    ganador = local;
                if (ptosLocal < ptosVisitante)
                    ganador = visitante;
                else 
                {
                    int i = 1;
                    while (ptosLocal == ptosVisitante)
                    {
                        JugarTiempoExtra(i);
                        if (ptosLocal == ptosVisitante)
                            i++;
                    }

                }

                Console.WriteLine($"GANADOR: {ganador.Nombre} ({ganador.Abreviacion}) ");

            }
 
            public void Simular() {

                SimularTiempoRegular();
                if (ptosLocal > ptosVisitante)
                    ganador = local;
                if (ptosLocal < ptosVisitante)
                    ganador = visitante;
                else 
                {
                    while (ptosLocal == ptosVisitante);
                        SimularTiempoExtra();

                }

            }

            private void JugarTiempoRegular() {

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"INICIO {i}/4 CUARTO");
                    for (int j = 1; j <= 10; j+=2)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine($"ATAQUE {j}:");
                        ptosLocal += RealizarAtaque(local, visitante, false);
                        Console.WriteLine("\n");
                        Console.WriteLine($"ATAQUE {j+1}:");
                        ptosVisitante += RealizarAtaque(visitante, local, false);
                    }
                    Console.WriteLine("\n");
                    if (i != 4)
                    {
                        Console.WriteLine($"FIN DE {i}/4 CUARTO");
                        Console.WriteLine($"{local.Abreviacion}: {ptosLocal} - {visitante.Abreviacion}: {ptosVisitante}");
                        Console.WriteLine("presionar espacio para comenzar el proximo cuarto..."); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("FIN DEL PARTIDO");
                        Console.WriteLine($"{local.Abreviacion}: {ptosLocal} - {visitante.Abreviacion}: {ptosVisitante}");
                    }

                }

            }

            private void SimularTiempoRegular() {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 10; j+=2)
                    {
                        ptosLocal += SimularAtaque(local, visitante, false);
                        ptosVisitante += SimularAtaque(visitante, local, false);
                    }
                }

                if (ptosLocal > ptosVisitante)
                    ganador = local;
                else
                    ganador = visitante;
                
            }

            private void JugarTiempoExtra(int i) {

                Console.WriteLine("\n");
                Console.WriteLine($"INICIO DE TIEMPO EXTRA {i}");
                for (int j = 1; j <= 10; j+=2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"ATAQUE {j}:");
                    ptosLocal += RealizarAtaque(local, visitante, false);
                    Console.WriteLine("\n");
                    Console.WriteLine($"ATAQUE {j+1}:");
                    ptosVisitante += RealizarAtaque(visitante, local, false);
                }

            }

            private void SimularTiempoExtra() {

                for (int j = 1; j <= 10; j+=2)
                {
                    ptosLocal += SimularAtaque(local, visitante, false);
                    ptosVisitante += SimularAtaque(visitante, local, false);
                }

            }

        }

        private static int RealizarAtaque(Equipo equipoAtacante, Equipo equipoDefensor, bool ataquePostRebote) {

            Console.WriteLine($"{equipoAtacante.Abreviacion} atacando, {equipoDefensor.Abreviacion} defendiendo");
            Console.WriteLine("\n");

            var tipoDeAtaque = DeterminarTipoDeAtaque();
            var tipoDeDefensa = DeterminarTipoDeDefensa(tipoDeAtaque);
            double probabilidadDeDefensa, probabilidadDeConversion;

            if (EsFalta(tipoDeDefensa, equipoDefensor)) {

                Console.WriteLine($"Falta de {equipoDefensor.Abreviacion}, Tiro libre para {equipoAtacante.Abreviacion}");
                if (CalcularExitoTiroLibre(equipoAtacante))
                {
                    Console.WriteLine("Tiro libre convertido");
                    return 1; // TIRO LIBRE CONVERTIDO
                }
                else
                {
                    Console.WriteLine("Tiro libre fallado");
                    return 0; // TIRO LIBRE FALLADO
                }
                

            } else
            {
                probabilidadDeDefensa = ObtenerProbabilidadDeDefensa(tipoDeAtaque, tipoDeDefensa, equipoDefensor);
                if (CalcularExitoDefensa((int)Math.Floor(probabilidadDeDefensa)))
                {
                    Console.WriteLine($"Defensa exitosa de {equipoDefensor.Abreviacion}");
                    return 0; // ATAQUE DEFENDIDO
                }
                else
                {
                    probabilidadDeConversion = ObtenerProbabilidadDeConversion(tipoDeAtaque, equipoAtacante, ataquePostRebote);
                    if (CalcularExitoConversion((int)Math.Floor(probabilidadDeConversion)))
                    {
                        if (tipoDeAtaque == TipoDeAtaque.Triple)
                        {
                            Console.WriteLine($"Triple convertido de {equipoAtacante.Abreviacion}");
                            return 3; // TRIPLE CONVERTIDO
                        }
                        else
                        {
                            Console.WriteLine($"Doble convertido de {equipoAtacante.Abreviacion}");
                            return 2; // BANDEJA O DUNK CONVERTIDO
                        }
                    } else
                    {
                        Console.WriteLine($"Tiro fallado de {equipoAtacante.Abreviacion}");
                        if (DisputarRebote() && !ataquePostRebote)  // SE DISPUTA EL REBOTE UNA SOLA VEZ POR POSESION
                        {
                            Console.WriteLine($"Rebote ganado por {equipoDefensor.Abreviacion}");
                            return 0; // TIRO FALLADO
                        }
                        else
                        {
                            Console.WriteLine($"Rebote ganado por {equipoAtacante.Abreviacion}");
                            return RealizarAtaque(equipoAtacante, equipoDefensor, true);
                        }
                    }

                }
            }

        }

        private static int SimularAtaque(Equipo equipoAtacante, Equipo equipoDefensor, bool ataquePostRebote) {

            var tipoDeAtaque = DeterminarTipoDeAtaque();
            var tipoDeDefensa = DeterminarTipoDeDefensa(tipoDeAtaque);
            double probabilidadDeDefensa, probabilidadDeConversion;

            if (EsFalta(tipoDeDefensa, equipoDefensor)) {

                if (CalcularExitoTiroLibre(equipoAtacante))
                {
                    return 1; // TIRO LIBRE CONVERTIDO
                }
                else
                {
                    return 0; // TIRO LIBRE FALLADO
                }
                

            } else
            {
                probabilidadDeDefensa = ObtenerProbabilidadDeDefensa(tipoDeAtaque, tipoDeDefensa, equipoDefensor);
                if (CalcularExitoDefensa((int)Math.Floor(probabilidadDeDefensa)))
                {
                    return 0; // ATAQUE DEFENDIDO
                }
                else
                {
                    probabilidadDeConversion = ObtenerProbabilidadDeConversion(tipoDeAtaque, equipoAtacante, ataquePostRebote);
                    if (CalcularExitoConversion((int)Math.Floor(probabilidadDeConversion)))
                    {
                        if (tipoDeAtaque == TipoDeAtaque.Triple)
                        {
                            return 3; // TRIPLE CONVERTIDO
                        }
                        else
                        {
                            return 2; // BANDEJA O DUNK CONVERTIDO
                        }
                    } else
                    {
                        if (DisputarRebote() && !ataquePostRebote)  // SE DISPUTA EL REBOTE UNA SOLA VEZ POR POSESION
                        {
                            return 0; // TIRO FALLADO
                        }
                        else
                        {
                            return SimularAtaque(equipoAtacante, equipoDefensor, true);
                        }
                    }

                }
            }

        }

        private static TipoDeAtaque DeterminarTipoDeAtaque() {

            var random = new Random();
            int opcion = random.Next(100);
            if (opcion < 50)
                return TipoDeAtaque.Bandeja;
            if (opcion >= 50 && opcion < 80)
                return TipoDeAtaque.Dunk;
            else
                return TipoDeAtaque.Triple;

        }

        private static TipoDeDefensa DeterminarTipoDeDefensa(TipoDeAtaque tipoDeAtaque) {
            
            var random = new Random();
            int opcion = random.Next(100);

            if (tipoDeAtaque == TipoDeAtaque.Bandeja)
            {
                if (opcion < 75)
                    return TipoDeDefensa.Bloqueo;
                else
                    return TipoDeDefensa.Robo;
            } else if (tipoDeAtaque == TipoDeAtaque.Dunk)
            {
                if (opcion < 70)
                    return TipoDeDefensa.Bloqueo;
                else
                    return TipoDeDefensa.Robo;
            } else /* if (tipoDeAtaque == TipoDeAtaque.Triple) */
            {
                if (opcion < 60)
                    return TipoDeDefensa.Bloqueo;
                else
                    return TipoDeDefensa.Robo;
            }

        }

        private static bool EsFalta(TipoDeDefensa tipoDeDefensa, Equipo equipoDefensor) {

            var random = new Random();
            double opcion = random.Next(100);

            if (tipoDeDefensa == TipoDeDefensa.Bloqueo) {
                if (opcion < (15 - 0.2 * (equipoDefensor.Estadisticas.DefensaPerimetro + equipoDefensor.Estadisticas.DefensaInterior)))
                    return true;
                else
                    return false;
            }
            if (tipoDeDefensa == TipoDeDefensa.Robo) {
                if (opcion < (10 - 0.2 * (equipoDefensor.Estadisticas.DefensaPerimetro + equipoDefensor.Estadisticas.DefensaInterior)))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private static double ObtenerProbabilidadDeDefensa(TipoDeAtaque tipoDeAtaque, TipoDeDefensa tipoDeDefensa, Equipo equipoDefensor) {

            var random = new Random();
            int factorSuerte = random.Next(-3, 3);
            double bonusEstadisticas = ObtenerBonusEstadisticasDefensa(tipoDeDefensa, equipoDefensor);

            if (tipoDeAtaque == TipoDeAtaque.Bandeja)
            {
                if (tipoDeDefensa == TipoDeDefensa.Bloqueo)
                    return 25 + bonusEstadisticas + factorSuerte;
                else
                    return 15 + bonusEstadisticas + factorSuerte;
            }
            if (tipoDeAtaque == TipoDeAtaque.Dunk)
            {
                if (tipoDeDefensa == TipoDeDefensa.Bloqueo)
                    return 20 + bonusEstadisticas + factorSuerte;
                else
                    return 10 + bonusEstadisticas + factorSuerte;
            }
            else /* if (tipoDeAtaque == TipoDeAtaque.Triple) */
            {
                if (tipoDeDefensa == TipoDeDefensa.Bloqueo)
                    return 10 + bonusEstadisticas + factorSuerte;
                else
                    return 5 + bonusEstadisticas + factorSuerte;
            }

        }

        private static double ObtenerBonusEstadisticasDefensa(TipoDeDefensa tipoDeDefensa, Equipo equipoDefensor) {

            double bonusEstadisticas;

            if (tipoDeDefensa == TipoDeDefensa.Bloqueo)
                    bonusEstadisticas = 0.2 * (equipoDefensor.Estadisticas.DefensaPerimetro + equipoDefensor.Estadisticas.DefensaInterior);
            else /* if (tipoDeDefensa == TipoDeDefensa.Robo) */
                bonusEstadisticas = 0.4 * equipoDefensor.Estadisticas.DefensaPerimetro;
            
            return bonusEstadisticas;

        }

        private static bool CalcularExitoDefensa (int probabilidadDeDefensa) {

            var random = new Random();
            var opcion = random.Next(100);

            if (opcion < probabilidadDeDefensa)
                return true;
            else
                return false;
            
        }

        private static double ObtenerProbabilidadDeConversion(TipoDeAtaque tipoDeAtaque, Equipo equipoAtacante, bool ataquePostRebote) {

            var random = new Random();
            int factorSuerte = random.Next(-5, 5);
            double bonusEstadisticas;
            int modificacionPostRebote;

            if (ataquePostRebote)
                modificacionPostRebote = 30;
            else
                modificacionPostRebote = 0;

            if (tipoDeAtaque == TipoDeAtaque.Bandeja)
            {
                bonusEstadisticas = 0.7 * equipoAtacante.Estadisticas.Creacion + 0.3 * equipoAtacante.Estadisticas.Tiro - modificacionPostRebote;
                return 60 + bonusEstadisticas + factorSuerte;
            }
            if (tipoDeAtaque == TipoDeAtaque.Dunk)
            {
                bonusEstadisticas = 0.7 * equipoAtacante.Estadisticas.Creacion + 0.3 * equipoAtacante.Estadisticas.Tiro - modificacionPostRebote;
                return 40 + bonusEstadisticas + factorSuerte;
            }
            else /* if (tipoDeAtaque == TipoDeAtaque.Triple) */
            {
                bonusEstadisticas = 0.3 * equipoAtacante.Estadisticas.Creacion + 0.7 * equipoAtacante.Estadisticas.Tiro - modificacionPostRebote;
                return 30 + bonusEstadisticas + factorSuerte;
            }

        }

        private static bool CalcularExitoConversion(int probabilidadDeConversion) {

            var random = new Random();
            var opcion = random.Next(100);

            if (opcion < probabilidadDeConversion)
                return true;
            else
                return false;

        }

        private static bool CalcularExitoTiroLibre(Equipo equipoAtacante) {

            int probabilidadDeConversionTiroLibre = ObtenerProbabilidadDeConversionTiroLibre(equipoAtacante);

            var random = new Random();
            int opcion = random.Next(100);

            if (opcion < probabilidadDeConversionTiroLibre)
                return true;
            else
                return false;

        }

        private static int ObtenerProbabilidadDeConversionTiroLibre(Equipo equipoAtacante) {

            var random = new Random();
            int factorSuerte = random.Next(-5, 5);

            return 75 + (int)Math.Floor(equipoAtacante.Estadisticas.Tiro) + factorSuerte;
        }

        private static bool DisputarRebote() {

            var random = new Random();
            int opcion = random.Next(100);

            if (opcion < 70)
                return true; // EQUIPO DEFENSOR GANA EL REBOTE
            else
                return false; // EQUIPO ATACANTE GANA EL REBOTE

        }

    }

    public static Dictionary<Fase, List<Partidos.Partido>> CrearCrucesCuartos(List<Equipo> equipos) {

        var DiccPartidos = new Dictionary<Fase, List<Partidos.Partido>>();
        DiccPartidos[Fase.Cuartos] = new List<Partidos.Partido>();

        for (int j = 0; j < 8; j+=2)
            DiccPartidos[Fase.Cuartos].Add(new Partidos.Partido(equipos[j], equipos[j+1], Fase.Cuartos)); 

        return DiccPartidos;
    }

    public static void CrearCrucesSemis(Dictionary<Fase, List<Partidos.Partido>> DiccPartidos) {

        DiccPartidos[Fase.Semis] = new List<Partidos.Partido>();
        for (int i = 0; i < 4; i+=2)
            {
                var semifinalista1 = DiccPartidos[Fase.Cuartos][i].Ganador;
                var semifinalista2 = DiccPartidos[Fase.Cuartos][i+1].Ganador;
                DiccPartidos[Fase.Semis].Add(new Partidos.Partido(semifinalista1, semifinalista2, Fase.Semis));
            }

    }

    public static void CrearFinal(Dictionary<Fase, List<Partidos.Partido>> DiccPartidos) {

        DiccPartidos[Fase.Final] = new List<Partidos.Partido>();
        var finalista1 = DiccPartidos[Fase.Semis][0].Ganador;
        var finalista2 = DiccPartidos[Fase.Semis][1].Ganador;
        DiccPartidos[Fase.Final].Add(new Partidos.Partido(finalista1, finalista2, Fase.Final));

    }

}
    
public enum TipoDeAtaque 
    {
        Bandeja,
        Dunk,
        Triple
    }

public enum TipoDeDefensa
    {
        Bloqueo,
        Robo,
        Falta,
        Fallida
    }

public enum Fase
    {
        Cuartos,
        Semis,
        Final
    }