class tiquetera
{
    public static int ultimoId { get; set; } = -1;


    public static int devolverUltimoId()
    {
        ultimoId++;
        return ultimoId;
    }

}