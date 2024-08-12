public class Equipo
{
    string nombre;
    string abreviacion;
    Personaje capitan;
    Personaje atacante;
    Personaje defensor;
    Estadisticas estadisticas;

    public Equipo(Personaje capitan, Personaje atacante, Personaje defensor)
    {
        this.capitan = capitan;
        this.atacante = atacante;
        this.defensor = defensor;
        estadisticas = new Estadisticas();
        estadisticas.Tiro = Math.Round((capitan.Estadisticas.Tiro + atacante.Estadisticas.Tiro + defensor.Estadisticas.Tiro) / 3, 1);
        estadisticas.Creacion = Math.Round((capitan.Estadisticas.Creacion + atacante.Estadisticas.Creacion + defensor.Estadisticas.Creacion) / 3, 1);
        estadisticas.DefensaPerimetro = Math.Round((capitan.Estadisticas.DefensaPerimetro + atacante.Estadisticas.DefensaPerimetro + defensor.Estadisticas.DefensaPerimetro) / 3, 1);
        estadisticas.DefensaInterior = Math.Round((capitan.Estadisticas.DefensaInterior + atacante.Estadisticas.DefensaInterior + defensor.Estadisticas.DefensaInterior) / 3, 1);
        estadisticas.Promedio = Math.Round((capitan.Estadisticas.Promedio + atacante.Estadisticas.Promedio + defensor.Estadisticas.Promedio) / 3, 1);
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
    public Personaje Capitan { get => capitan; set => capitan = value; }
    public Personaje Atacante { get => atacante; set => atacante = value; }
    public Personaje Defensor { get => defensor; set => defensor = value; }
    public Estadisticas Estadisticas { get => estadisticas; set => estadisticas = value; }
}