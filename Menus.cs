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

    public static Personaje[] seleccionPersonajes(List<Personaje> capitanes, List<Personaje> atacantes, List<Personaje> defensores) {
        var personajesSeleccionados = new Personaje[3];
        int opcion; bool b = true;

        Console.WriteLine("\tSELECCIONAR CAPITAN");
        mostrarPersonajes(capitanes);
        do
        {
            
            Console.WriteLine("\nSeleccion: ");
            b = int.TryParse(Console.ReadLine(), out opcion);
            if (opcion < 0 || opcion > 8 || !b) {
                Console.WriteLine("Opcion no valida, ingresar nuevamente");
                b = false;
            }
            
        } while (!b);
        personajesSeleccionados[0] = capitanes.ElementAt(opcion-1);

        Console.WriteLine("\tSELECCIONAR ATACANTE");
        mostrarPersonajes(atacantes);
        do
        {
            
            Console.WriteLine("\nSeleccion: ");
            b = int.TryParse(Console.ReadLine(), out opcion);
            if (opcion < 0 || opcion > 8 || !b) {
                Console.WriteLine("Opcion no valida, ingresar nuevamente");
                b = false;
            }
            
        } while (!b);
        personajesSeleccionados[1] = atacantes.ElementAt(opcion-1);

        Console.WriteLine("\tSELECCIONAR DEFENSORES");
        mostrarPersonajes(defensores);
        do
        {
            
            Console.WriteLine("\nSeleccion: ");
            b = int.TryParse(Console.ReadLine(), out opcion);
            if (opcion < 0 || opcion > 8 || !b) {
                Console.WriteLine("Opcion no valida, ingresar nuevamente");
                b = false;
            }
            
        } while (!b);
        personajesSeleccionados[2] = defensores.ElementAt(opcion-1);

        return personajesSeleccionados;
    }

    public static void mostrarPersonajes(List<Personaje> listaPersonajes) {

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

}
