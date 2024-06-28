
public class Personaje
{
    Datos datos;
    Estadisticas estadisticas;

    public Personaje()
    {
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
    string apellido;
    int numero;
    string nacionalidad;
    Equipo equipo;

    public Datos(int id, string nombre, string apellido, int numero, string nacionalidad, Equipo equipo)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.numero = numero;
        this.nacionalidad = nacionalidad;
        this.equipo = equipo;
    }

    public int Id { get => id; set => id = value; }
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

    public Equipo(string nombre, string abreviacion)
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