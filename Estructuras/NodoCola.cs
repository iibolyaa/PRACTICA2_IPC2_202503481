using PRACTICA2_IPC2_202503481.Modelos;

namespace PRACTICA2_IPC2_202503481.Estructuras;
public class NodoCola
{
    public NodoCola(Cancion cancion)
    {
        Cancion = cancion;
        Siguiente = null;
    }

    public Cancion Cancion { get; set; }
    public NodoCola Siguiente { get; set; }
}