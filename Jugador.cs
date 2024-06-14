
using System.Text.Json.Serialization;

public class JugadorData
{

    List<Jugador> listaJugadores;

    [JsonPropertyName("data")]
    public List<Jugador> ListaJugadores { get => listaJugadores; set => listaJugadores = value; }

}
public class Jugador
{
    
    int id;
    string firstName;
    string lastName;
    int jerseyNumber;
    string country;
    Team team;

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
