using System.Net.NetworkInformation;

public static class Jugadores
{
    public static Dictionary<int, string> obtenerDiccionarioJugadores() {
        
        var diccionarioJugadores = new Dictionary<int, string>()
        {

            // CAPITANES
            {15, "Giannis Antetkounmpo"},
            {132, "Luka Doncic"},
            {140, "Kevin Durant"},
            {175, "Shai Gilgeous-Alexander"},
            {192, "James Harden"},
            {228, "Kyrie Irving"},
            {237, "Lebron James"},
            {434, "Jayson Tatum"},

            // DEFENSORES
            {4, "Bam Adebayo"},
            {117, "Anthony Davis"},
            {145, "Joel Embiid"},
            {176, "Rudy Gobert"},
            {246, "Nikola Jokic"},
            {274, "Kawhi Leonard"},
            {378, "Kristaps Porzingis"},
            {666969, "Zion Williamson"},

            // ATACANTES
            {57, "Devin Booker"},
            {70, "Jaylen Brown"},
            {115, "Stephen Curry"},
            {490, "Trae Young"},
            {666786, "Ja Morant"},
            {3547238, "Anthony Edwards"},
            {3547239, "LaMello Ball"},
            {3547245, "Tyrese Haliburton"}

        };

        return diccionarioJugadores;
    }

    public static string obtenerURLJugadores(Dictionary <int, string> diccionarioJugadores) {

        string url = "https://api.balldontlie.io/v1/players?";

        foreach (var jugador in diccionarioJugadores)
        {
            
            url += $"player_ids[]={jugador.Key}&";

        }
        url += "per_page=100";

        return url;
    }

}