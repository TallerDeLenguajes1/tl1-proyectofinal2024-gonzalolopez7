
using System.Text.Json.Serialization;

public class TeamsData {

    List<Teams> teamsList;

    [JsonPropertyName("data")]
    public List<Teams> TeamsList { get => teamsList; set => teamsList = value; }
}

public class Teams
{
    
    string nombre;
    string abreviacion;

    [JsonPropertyName("full_name")]
    public string Nombre { get => nombre; set => nombre = value; }

    [JsonPropertyName("abbreviation")]
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
}