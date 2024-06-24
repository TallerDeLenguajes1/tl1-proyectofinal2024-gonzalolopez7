using System.Text.Json.Serialization;

public class JugadorData
{
    List<Jugador> listaJugadores;

    [JsonPropertyName("data")]
    public List<Jugador> ListaJugadores { get => listaJugadores; set => listaJugadores = value; }
}

public class StatsData
{
    List<Stats> listaStats;

    [JsonPropertyName("data")]
    public List<Stats> ListaStats { get => listaStats; set => listaStats = value; }
}

public class Jugador
{ 
    int id;
    string firstName;
    string lastName;
    int jerseyNumber;
    string country;
    Team team;
    Stats stats;

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
    public Stats Stats { get => stats; set => stats = value; }
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

public class Stats
{
    int id;
    double fg;
    double fg3;
    double ft;
    double ast;
    double to;
    double stl;
    double dreb;
    double blk;

    [JsonPropertyName("player_id")]
    public int Id { get => id; set => id = value; }

    [JsonPropertyName("fg_pct")]
    public double Fg { get => fg; set => fg = value; }

    [JsonPropertyName("fg3_pct")]
    public double Fg3 { get => fg3; set => fg3 = value; }

    [JsonPropertyName("ft_pct")]
    public double Ft { get => ft; set => ft = value; }

    [JsonPropertyName("ast")]
    public double Ast { get => ast; set => ast = value; }

    [JsonPropertyName("turnover")]
    public double To { get => to; set => to = value; }

    [JsonPropertyName("stl")]
    public double Stl { get => stl; set => stl = value; }

    [JsonPropertyName("dreb")]
    public double Dreb { get => dreb; set => dreb = value; }

    [JsonPropertyName("blk")]
    public double Blk { get => blk; set => blk = value; }
}

public enum Rol
{
    Capitan,
    Atacante,
    Defensor
}