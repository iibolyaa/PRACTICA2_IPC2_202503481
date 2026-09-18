using PRACTICA2_IPC2_202503481.Modelos;

namespace PRACTICA2_IPC2_202503481.Estructuras;
public class ArbolCanciones
{
    private NodoArbol raiz;
    public ArbolCanciones()
    {
        raiz = null;
    }

    public void Insertar(Cancion cancion)
    {
        NodoArbol nuevo = new NodoArbol(cancion);

        if(raiz == null)
        {
            raiz = nuevo;
            return;
        }

        InsertarNodo(raiz, nuevo);
    }

    private void InsertarNodo(NodoArbol actual, NodoArbol nuevo)
    {
        int comparacion = string.Compare(nuevo.Cancion.Titulo, actual.Cancion.TItulo, true);

        if(comparacion < 0)
        {
            if(actual.Izquierda == null)
            {
                actual.Izquierda = nuevo;
            }
            else
            {
                InsertarNodo(actual.Izquierda, nuevo);
            }
        }
        else
        {
            if(actual.Derecha == null)
            {
                actual.Derecha = nuevo;
            }
            else{
                InsertarNodo(actual.Derecha, nuevo);
            }
        }
    }

    public Cancion Buscar(string Titulo)
    {
        NodoArbol actual = raiz;

        while(actual != null)
        {
            int comparacion = string.Compare(titulo, actual.Cancion.Titulo, true);

            if(comparacion == 0)
            {
                return actual.Cancion;
            }

            if(comparacion < 0){
                actual = actual.Izquierda;
            }
            else
            {
                actual = actual.Derecha;
            }
        }
        return null;
    }
}