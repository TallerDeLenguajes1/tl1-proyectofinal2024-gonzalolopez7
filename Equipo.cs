public class Equipo
{
    string nombre;
    string abreviacion;
    Personaje capitan;
    Personaje atacante;
    Personaje defensor;
    Estadisticas estadisticas;

    public Equipo()
    {
    }

    public Equipo(Personaje capitan, Personaje atacante, Personaje defensor)
    {
        this.capitan = capitan;
        this.atacante = atacante;
        this.defensor = defensor;
        estadisticas.Tiro = (capitan.Estadisticas.Tiro + atacante.Estadisticas.Tiro + defensor.Estadisticas.Tiro) / 3;
        estadisticas.Creacion = (capitan.Estadisticas.Creacion + atacante.Estadisticas.Creacion + defensor.Estadisticas.Creacion) / 3;
        estadisticas.DefensaPerimetro = (capitan.Estadisticas.DefensaPerimetro + atacante.Estadisticas.DefensaPerimetro + defensor.Estadisticas.DefensaPerimetro) / 3;
        estadisticas.DefensaInterior = (capitan.Estadisticas.DefensaInterior + atacante.Estadisticas.DefensaInterior + defensor.Estadisticas.DefensaInterior) / 3;
        estadisticas.Promedio = (capitan.Estadisticas.Promedio + atacante.Estadisticas.Promedio + defensor.Estadisticas.Promedio) / 3;;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
    public Personaje Capitan { get => capitan; set => capitan = value; }
    public Personaje Atacante { get => atacante; set => atacante = value; }
    public Personaje Defensor { get => defensor; set => defensor = value; }
    public Estadisticas Estadisticas { get => estadisticas; set => estadisticas = value; }
}