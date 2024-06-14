
using System.Text.Json.Serialization;

public class JugadorData
{

    List<Jugador> listaJugadores;

    [JsonPropertyName("data")]
    public List<Jugador> ListaJugadores { get => listaJugadores; set => listaJugadores = value; }

}

public class EstadisticasData
{

    List<Estadisticas> listaEstadisticas;

    [JsonPropertyName("data")]
    public List<Estadisticas> ListaEstadisticas { get => listaEstadisticas; set => listaEstadisticas = value; }
}

public class Jugador
{
    
    int id;
    string firstName;
    string lastName;
    int jerseyNumber;
    string country;
    Team team;

    Estadisticas estadisticas;

    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }

    [JsonPropertyName("first_name")]
    public string FirstName { get => firstName; set => firstName = value; }

    [JsonPropertyName("last_name")]
    public string LastName { get => lastName; set => lastName = value; }

    [JsonPropertyName("jersey_number")]
    public int JerseyNumber { get => jerseyNumber; set => jerseyNumber = value; }

    [JsonPropertyName("country")]
    public string Country { get => country; set => country = value; }

    [JsonPropertyName("team")]
    public Team Team { get => team; set => team = value; }

    [JsonPropertyName("stats")]
    public Estadisticas Estadisticas { get => estadisticas; set => estadisticas = value; }
}
public class Team
{

    string fullName;
    string abbreviation;

    [JsonPropertyName("full_name")]
    public string FullName { get => fullName; set => fullName = value; }

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get => abbreviation; set => abbreviation = value; }

}

public class Estadisticas
{

    int id;
    float fg;
    float fg3;
    float ft;
    float ast;
    float to;
    float stl;
    float dreb;
    float blk;

    [JsonPropertyName("player_id")]
    public int Id { get => id; set => id = value; }

    [JsonPropertyName("fg_pct")]
    public float Fg { get => fg; set => fg = value; }

    [JsonPropertyName("fg3_pct")]
    public float Fg3 { get => fg3; set => fg3 = value; }

    [JsonPropertyName("ft_pct")]
    public float Ft { get => ft; set => ft = value; }

    [JsonPropertyName("ast")]
    public float Ast { get => ast; set => ast = value; }

    [JsonPropertyName("turnover")]
    public float To { get => to; set => to = value; }

    [JsonPropertyName("stl")]
    public float Stl { get => stl; set => stl = value; }

    [JsonPropertyName("dreb")]
    public float Dreb { get => dreb; set => dreb = value; }

    [JsonPropertyName("blk")]
    public float Blk { get => blk; set => blk = value; }

}