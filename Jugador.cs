public class Jugador
{
    
    int id;
    string firstName;
    string lastName;
    int jerseyNumber;
    string country;
    Team team;

    public int Id { get => id; set => id = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int JerseyNumber { get => jerseyNumber; set => jerseyNumber = value; }
    public string Country { get => country; set => country = value; }
    public Team Team { get => team; set => team = value; }
}
public class Team
{

    string fullName;
    string abbreviation;

    public string FullName { get => fullName; set => fullName = value; }
    public string Abbreviation { get => abbreviation; set => abbreviation = value; }

}
