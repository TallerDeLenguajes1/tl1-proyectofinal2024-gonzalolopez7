
public class Personaje
{
    Datos datos;
    Estadisticas estadisticas;

    public Datos Datos { get => datos; set => datos = value; }
    public Estadisticas Estadisticas { get => estadisticas; set => estadisticas = value; }
}

public class Datos
{

    string nombre;
    string apellido;
    int numero;
    string nacionalidad;
    Equipo equipo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    public Equipo Equipo { get => equipo; set => equipo = value; } 
}

public class Equipo
{
    string nombre;
    string abreviacion;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Abreviacion { get => abreviacion; set => abreviacion = value; }
}

public class Estadisticas
{
    float tiro;
    float creacion;
    float defensaPerimetro;
    float defensaInterior;

    public float Tiro { get => tiro; set => tiro = value; }
    public float Creacion { get => creacion; set => creacion = value; }
    public float DefensaPerimetro { get => defensaPerimetro; set => defensaPerimetro = value; }
    public float DefensaInterior { get => defensaInterior; set => defensaInterior = value; }
}