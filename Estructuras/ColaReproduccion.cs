using PRACTICA2_IPC2_202503481.Modelos;

namespace PRACTICA2_IPC2_202503481.Estructuras;

public class ColaReproduccion
{
    private NodoCola primero;
    private NodoCola ultimo;

    public ColaReproduccion()
    {
        primero = null;
        ultimo = null;
    }

    public bool EstaVacia()
    {
        return primero == null;
    }

    public void Encolar(Cancion cancion)
    {
        NodoCola nuevo = new NodoCola(cancion);

            if(EstaVacia())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
    }

    public Cancion Desencolar()
    {
        if (EstaVacia())
        {
            return null;
        }

        Cancion cancion = primero.Cancion;
        primero = primero.Siguiente;

        if(primero == null)
        {
            ultimo = null;
        }

        return cancion;
    }

    public int CalcularTiempoTotal()
    {
        int total = 0;

        NodoCola actual = primero;

        while(actual != null)
        {
            total += actual.Cancion.DuracionMinutos;
            actual = actual.Siguiente;
     
       }
       
       return total;
    }
}