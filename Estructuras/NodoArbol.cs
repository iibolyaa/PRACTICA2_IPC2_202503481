using PRACTICA2_IPC2_202503481.Modelos;

namespace PRACTICA2_IPC2_202503481.Estructuras;
public class NodoArbol
{
    public NodoArbol(Cancion cancion)
    {
        Cancion = cancion;
        Izquierda = null;
        Derecha = null;
    }

    public Cancion Cancion { get; set; }

    public NodoArbol Izquierda { get; set; }

    public NodoArbol Derecha { get; set; }
}