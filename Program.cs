List<cliente> datosCliente = new List<cliente>();
int op = ingresarInt("1. Nueva Inscripcion\n2. Obtener Estadisticas del Evento\n3. Buscar Cliente\n4. Cambiar Entrada de un Cliente\n5. Salir");
int ID = 0;
while (op != 4)
{
    switch (op)
    {
        case 1:
            cargarCliente(ID);
            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
    }
    op = ingresarInt("1. Cargar Datos Boxeador 1.\n2. Cargar Datos Boxeador 2.\n3. Pelar.\n4. Salir");
}

static int ingresarInt(string txt)
{
    int num;
    Console.WriteLine(txt);
    num = int.Parse(Console.ReadLine());
    return num;
}

static double ingresarDouble(string txt)
{
    double num;
    Console.WriteLine(txt);
    num = int.Parse(Console.ReadLine());
    return num;
}

static string ingresarString(string txt)
{
    string palabra;
    Console.WriteLine(txt);
    palabra = Console.ReadLine();
    return palabra;
}

static cliente cargarCliente(int ID)
{
    int dni = ingresarInt("Ingrese su DNI");
    string apellido = ingresarString("Ingrese su Apellido:");
    string nombre = ingresarString("Ingrese su Nombre:");
    DateTime fechaInscripcion = DateTime.Today;
    int tipoEntrada = ingresarInt("Ingrese el tipo de entrada:\nOpcion 1 - Día 1 , valor a abonar $15000\nOpción 2 - Día 2, valor a abonar $30000\nOpción 3 - Día 3, valor a abonar $10000\nOpción 4 - Full Pass, valor a abonar $40000");
    double valorAbonado = ingresarDouble("Ingrese el dinero que va a abonar:");
    verificarAbono(tipoEntrada, valorAbonado);
    ID = ID++;

    
}

static double verificarAbono(int tipoEntrada, double valorAbono)
{
    string msjError = "El valor abonado es menor de lo necesitado. Vuelva a Ingresar:";
    int op1 = 15000;
    int op2 = 30000;
    int op3 = 10000;
    int op4 = 40000;

    if (tipoEntrada == 1)
    {
        while(valorAbono < 15000){
            valorAbono = ingresarDouble(msjError);
        }
    }
    else if (tipoEntrada == 2)
    {
        while(valorAbono < 30000){
            valorAbono = ingresarDouble(msjError);
        }
    }
    else if (tipoEntrada == 3)
    {
        while(valorAbono < 10000){
            valorAbono = ingresarDouble(msjError);
        }
    }
    else
    {
        while(valorAbono < 40000){
            valorAbono = ingresarDouble(msjError);
        }
    }

    return valorAbono;
}