
using System.Text.Json.Serialization;

public class TeamsData {

    List<Teams> teamsList;

    [JsonPropertyName("data")]
    public List<Teams> TeamsList { get => teamsList; set => teamsList = value; }
}

public class Teams
{
    
    string full_name;
    string abbreviation;

    [JsonPropertyName("full_name")]
    public string Fullname { get => full_name; set => full_name = value; }

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get => abbreviation; set => abbreviation = value; }
}