class cliente
{
    public string dni { get; private set; }
    public string apellido { get; private set; }

    public string nombre { get; private set; }
    public DateTime fechaInscripcion { get; private set; }

    public int tipoEntrada { get; private set; }
    public double totalAbonado { get; private set; }

    public cliente(string Dni, string Apellido, string Nombre, int TipoEntrada, double TotalAbonado)
    {
        Dni = dni;
        apellido = Apellido;
        nombre = Nombre;
        tipoEntrada = TipoEntrada;
        totalAbonado = TotalAbonado;
        fechaInscripcion = DateTime.Now;
    }


}