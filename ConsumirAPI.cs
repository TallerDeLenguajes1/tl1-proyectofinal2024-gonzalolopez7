using System.Net.Http.Json;
public static class ConsumirAPI
{
    private static Dictionary<Rol, Dictionary<int, string>> obtenerDiccionarioJugadores()
    {
        var diccionarioCapitanes = new Dictionary<int, string>()
        {
            {15, "Giannis Antetkounmpo"},
            {132, "Luka Doncic"},
            {140, "Kevin Durant"},
            {175, "Shai Gilgeous-Alexander"},
            {192, "James Harden"},
            {228, "Kyrie Irving"},
            {237, "Lebron James"},
            {434, "Jayson Tatum"}
        };
        
        var diccionarioAtacantes = new Dictionary<int, string>()
        {
            {57, "Devin Booker"},
            {70, "Jaylen Brown"},
            {115, "Stephen Curry"},
            {490, "Trae Young"},
            {666786, "Ja Morant"},
            {3547238, "Anthony Edwards"},
            {3547239, "LaMello Ball"},
            {3547245, "Tyrese Haliburton"}
        };

        var diccionarioDefensores = new Dictionary<int, string>()
        {
            {4, "Bam Adebayo"},
            {117, "Anthony Davis"},
            {145, "Joel Embiid"},
            {176, "Rudy Gobert"},
            {246, "Nikola Jokic"},
            {274, "Kawhi Leonard"},
            {378, "Kristaps Porzingis"},
            {666969, "Zion Williamson"}
        };

        var diccionarioJugadores = new Dictionary<Rol, Dictionary<int, string>>(){
            {Rol.Capitan, diccionarioCapitanes},
            {Rol.Atacante, diccionarioAtacantes},
            {Rol.Defensor, diccionarioDefensores}
        };

        return diccionarioJugadores;
    }

    private static string ObtenerURLJugadores(Dictionary <Rol, Dictionary<int, string>> diccionarioJugadores, Rol rol)
    {
        string url = "https://api.balldontlie.io/v1/players?";

        foreach (var diccionario in diccionarioJugadores)
        {  
            if (rol == diccionario.Key)
            { 
                foreach (var jugador in diccionario.Value)
                {  
                    url += $"player_ids[]={jugador.Key}&";
                }
                break;
            }
        }

        url += "&";
        return url;
    }

    private static string ObtenerURLEstadisticas(List<APIPlayers> listaJugadores, int season)
    {
        string url = $"https://api.balldontlie.io/v1/season_averages?season={season}&";

        foreach (var jugador in listaJugadores)
        {
            url += $"player_ids[]={jugador.Id}";
            if (listaJugadores.Last() != jugador)
            {
                url += "&";
            }
        }

        return url;
    }

    public static async Task<List<APIPlayers>> ObtenerListaJugadores(Rol rol)
    {
        var diccionarioJugadores = ConsumirAPI.obtenerDiccionarioJugadores();
        string urlPlayers = ConsumirAPI.ObtenerURLJugadores(diccionarioJugadores, rol);
        string apiKey = "d464875f-8435-459e-9caa-4cbd46861aed";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", apiKey);

        HttpResponseMessage response = await client.GetAsync(urlPlayers);
        response.EnsureSuccessStatusCode();

        APIPlayersData playersResponseBody = await response.Content.ReadFromJsonAsync<APIPlayersData>();
        List<APIPlayers> playerList = playersResponseBody.playerList;

        string urlStats = ConsumirAPI.ObtenerURLEstadisticas(playerList, 2023);

        response = await client.GetAsync(urlStats);
        response.EnsureSuccessStatusCode();

        APIStatsData statsResponseBody = await response.Content.ReadFromJsonAsync<APIStatsData>();
        statsResponseBody.statList = statsResponseBody.statList.OrderBy(Estadisticas => Estadisticas.Id).ToList();

        for (int i = 0; i < playerList.Count(); i++)
        {
            playerList[i].Stats = statsResponseBody.statList[i];
        }

        return playerList;
    }

    public static async Task<List<APITeams>> ObtenerEquipos() {
        string urlTeams = "https://api.balldontlie.io/v1/teams";
        string apiKey = "d464875f-8435-459e-9caa-4cbd46861aed";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", apiKey);

        HttpResponseMessage response = await client.GetAsync(urlTeams);
        response.EnsureSuccessStatusCode();

        APITeamsData teamsResponseBody = await response.Content.ReadFromJsonAsync<APITeamsData>();
        List<APITeams> teamsList = teamsResponseBody.TeamsList;

        return teamsList;
    }
}