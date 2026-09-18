namespace PRACTICA2_IPC2_202503481.Modelos;
public class Cancion
{
    public Cancion(string titulo, string artista, string genero, int duracion)
    {
        Titulo = titulo.Trim;
        Artista = artista.Trim;
        Genero = genero.Trim;
        DuracionMinutos = duracion;
    }

    public string Titulo { get; }
    public string Artista { get; }
    public string Genero { get; }
    public int DuracionMinutos { get; }

    public string MostrarInformacion()
    {
        return "Título: " + Titulo +
            "\nArtista: " + Artista +
            "\nGénero: " + Genero +
            "\nDuración: " + Duracion + " minutos";
    }
}