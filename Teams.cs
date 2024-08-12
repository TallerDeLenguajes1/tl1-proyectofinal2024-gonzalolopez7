using System.Text.Json.Serialization;

public class APITeamsData {

    List<APITeams> teamsList;

    [JsonPropertyName("data")]
    public List<APITeams> TeamsList { get => teamsList; set => teamsList = value; }
}

public class APITeams
{
    
    string full_name;
    string abbreviation;

    [JsonPropertyName("full_name")]
    public string Fullname { get => full_name; set => full_name = value; }

    [JsonPropertyName("abbreviation")]
    public string Abbreviation { get => abbreviation; set => abbreviation = value; }
}