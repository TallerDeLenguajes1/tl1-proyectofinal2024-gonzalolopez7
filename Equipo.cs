public class Equipo
{
    string nombre;
    string abreviacion;

    Personaje capitan;
    Personaje atacante;
    Personaje defensor;
    Estadisticas estadisticasEquipo;

    public Equipo()
    {
    }

    public Equipo(Personaje capitan, Personaje atacante, Personaje defensor)
    {
        this.capitan = capitan;
        this.atacante = atacante;
        this.defensor = defensor;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
    public Personaje Capitan { get => capitan; set => capitan = value; }
    public Personaje Atacante { get => atacante; set => atacante = value; }
    public Personaje Defensor { get => defensor; set => defensor = value; }
    public Estadisticas EstadisticasEquipo { get => estadisticasEquipo; set => estadisticasEquipo = value; }
}