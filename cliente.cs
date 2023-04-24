class cliente
{
    public int dni {get; private set;}
    public string apellido {get; private set;}

    public string nombre {get; private set;}
    public DateTime fechaInscripcion {get; private set;}

    public int tipoEntrada {get; private set;}
    public double totalAbonado {get; private set;}

    public cliente(int Dni, string Apellido, string Nombre, DateTime FechaInscripcion, int TipoEntrada, double TotalAbonado){
        Dni = dni;
        apellido = Apellido;
        nombre = Nombre;
        fechaInscripcion = FechaInscripcion;
        tipoEntrada = TipoEntrada;
        totalAbonado = TotalAbonado;
    }
}