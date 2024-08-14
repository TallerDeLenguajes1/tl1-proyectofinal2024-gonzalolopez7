using System.Text.Json.Serialization;

public class Personaje
{
    Datos datos;
    Estadisticas estadisticas;

    public Personaje() {

    }

    public Personaje(Datos datos, Estadisticas estadisticas)
    {
        this.datos = datos;
        this.estadisticas = estadisticas;
    }

    public Datos Datos { get => datos; set => datos = value; }

    public Estadisticas Estadisticas { get => estadisticas; set => estadisticas = value; }
}

public class Datos
{
    int id;
    string nombre;
    int numero;
    string nacionalidad;
    DatosEquipo equipo;

    public Datos(){

    }

    public Datos(int id, string nombre, string apellido, int numero, string nacionalidad, DatosEquipo equipo)
    {
        this.id = id;
        this.nombre = nombre + " " + apellido;
        this.numero = numero;
        this.nacionalidad = nacionalidad;
        this.equipo = equipo;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    public DatosEquipo Equipo { get => equipo; set => equipo = value; }
}

public class DatosEquipo
{
    string nombre;
    string abreviacion;

    public DatosEquipo(string nombre, string abreviacion)
    {
        this.nombre = nombre;
        this.abreviacion = abreviacion;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
}

public class Estadisticas
{
    double tiro;
    double creacion;
    double defensaPerimetro;
    double defensaInterior;
    double promedio;

    public Estadisticas(){
        
    }

    public Estadisticas(double tiro, double creacion, double defensaPerimetro, double defensaInterior, double promedio)
    {
        this.tiro = tiro;
        this.creacion = creacion;
        this.defensaPerimetro = defensaPerimetro;
        this.defensaInterior = defensaInterior;
        this.promedio = promedio;
    }

    public double Tiro { get => tiro; set => tiro = value; }
    public double Creacion { get => creacion; set => creacion = value; }
    public double DefensaPerimetro { get => defensaPerimetro; set => defensaPerimetro = value; }
    public double DefensaInterior { get => defensaInterior; set => defensaInterior = value; }
    public double Promedio { get => promedio; set => promedio = value; }
}

public class EquipoCampeon
{
    
    string nombre;
    string capitan;
    string atacante;
    string defensor;

    public EquipoCampeon(string nombre, string capitan, string atacante, string defensor)
    {
        this.nombre = nombre;
        this.capitan = capitan;
        this.atacante = atacante;
        this.defensor = defensor;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Capitan { get => capitan; set => capitan = value; }
    public string Atacante { get => atacante; set => atacante = value; }
    public string Defensor { get => defensor; set => defensor = value; }
}