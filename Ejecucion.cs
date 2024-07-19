using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

public static class Ejecucion
{
    
    public static List<Personaje> CrearPersonajes(List<APIPlayer> jugadores, Rol rol) {
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

    }

    public static class Equipos
    {

        public static List<Equipo> CrearEquipos(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores, List<Teams> equiposAPI) {

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
            capitan = capitanes.ElementAt(opcion-1);

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
            atacante = atacantes.ElementAt(opcion-1);

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
            defensor = defensores.ElementAt(opcion-1);

            var equipoUsuario = new Equipo(
                capitan,
                atacante,
                defensor
            );

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

        private static Teams ElegirNombreEquipo(List<Teams> equipos) {
            int opcion; bool b = true;

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

        // se puede optimizar la funcion eliminando la variable equipoUsuario y pasando equipos[0] como referencia a la funcion ElegirNombreEquipo
        private static void AsignarNombreEquipos(List<Equipo> equipos, List<Teams> equiposAPI) {

            var equipoUsuario = ElegirNombreEquipo(equiposAPI);
            equipos[0].Nombre = equipoUsuario.Fullname;
            equipos[0].Abreviacion = equipoUsuario.Abbreviation;

            Random random = new Random();
            var equiposAPIDesordenados = equiposAPI.OrderBy(x => random.Next()).ToList();
            equiposAPIDesordenados.Remove(equipoUsuario);

            for (int i = 1; i < 7; i++)
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
            FasePartido fase;
            int ptosLocal;
            int ptosVisitante;
            Equipo ganador;

            public Equipo Local { get => local; set => local = value; }
            public Equipo Visitante { get => visitante; set => visitante = value; }
            public int PtosLocal { get => ptosLocal; }
            public int PtosVisitante { get => ptosVisitante; }
            private FasePartido Fase { get => fase; }

            public void JugarPartido() {



            }

        }

        private static int RealizarAtaque(Equipo equipoAtacante, Equipo equipoDefensor) {
            
            var tipoDeAtaque = DeterminarTipoDeAtaque();
            var tipoDeDefensa = DeterminarTipoDeDefensa(tipoDeAtaque, equipoDefensor);
            double probabilidadDeDefensa, probabilidadDeConversion;

            if (EsFalta(tipoDeDefensa, equipoDefensor)) {

                // TIRAR FALTA

            } else
            {
                probabilidadDeDefensa = ObtenerProbabilidadDeDefensa(tipoDeAtaque, tipoDeDefensa, equipoDefensor);
                if (CalcularExitoDeDefensa((int)Math.Floor(probabilidadDeDefensa)))
                    return 0;   // DEFENSA EXITOSA
                else
                {
                    probabilidadDeConversion = ObtenerProbabilidadDeConversion(tipoDeAtaque, equipoAtacante);
                    if (CalcularExitoDeConversion((int)Math.Floor(probabilidadDeConversion)))
                    {
                        if (tipoDeAtaque == TipoDeAtaque.Triple)
                            return 3;
                        else
                            return 2;
                    } else
                        return 0;   // TIRO FALLADO, DISPUTA DE REBOTE
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

        private static TipoDeDefensa DeterminarTipoDeDefensa(TipoDeAtaque tipoDeAtaque, Equipo equipoDefensor) {
            
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

        private static bool CalcularExitoDeDefensa (int probabilidadDeDefensa) {

            var random = new Random();
            var opcion = random.Next(100);

            if (opcion < probabilidadDeDefensa)
                return true;
            else
                return false;
            
        }

        private static double ObtenerProbabilidadDeConversion(TipoDeAtaque tipoDeAtaque, Equipo equipoAtacante) {

            var random = new Random();
            int factorSuerte = random.Next(-5, 5);
            double bonusEstadisticas;

            if (tipoDeAtaque == TipoDeAtaque.Bandeja)
            {
                bonusEstadisticas = 0.7 * equipoAtacante.Estadisticas.Creacion + 0.3 * equipoAtacante.Estadisticas.Tiro;
                return 60 + bonusEstadisticas + factorSuerte;
            }
            if (tipoDeAtaque == TipoDeAtaque.Dunk)
            {
                bonusEstadisticas = 0.7 * equipoAtacante.Estadisticas.Creacion + 0.3 * equipoAtacante.Estadisticas.Tiro;
                return 40 + bonusEstadisticas + factorSuerte;
            }
            else /* if (tipoDeAtaque == TipoDeAtaque.Triple) */
            {
                bonusEstadisticas = 0.3 * equipoAtacante.Estadisticas.Creacion + 0.7 * equipoAtacante.Estadisticas.Tiro;
                return 30 + bonusEstadisticas + factorSuerte;
            }

        }

        private static bool CalcularExitoDeConversion(int probabilidadDeConversion) {

            var random = new Random();
            var opcion = random.Next(100);

            if (opcion < probabilidadDeConversion)
                return true;
            else
                return false;

        }

    }

    private enum TipoDeAtaque 
    {
        Bandeja,
        Dunk,
        Triple
    }

    private enum TipoDeDefensa
    {
        Bloqueo,
        Robo,
        Falta,
        Fallida
    }
}

enum FasePartido
        {
            CuartoDeFinal,
            Semifinal,
            Final
        }