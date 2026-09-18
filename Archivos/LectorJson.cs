using System;
using System.IO;
using System.Text.Json;
using PRACTICA2_IPC2_202503481.Modelos;
using PRACTICA2_IPC2_202503481.Estructuras;
using PRACTICA2_IPC2_202503481.Datos;

namespace PRACTICA2_IPC2_202503481.Archivos;
public class LectorJson
{
    public static void CargarCanciones(string ruta, ColaReproduccion cola, ArbolCanciones arbol)
    {
        if (!File.Exists(ruta))
            {
                Console.WriteLine("No se encontró el archivo JSON.");
                return;
            }

            string contenido = File.ReadAllText(ruta);

            using (JsonDocument documento = JsonDocument.Parse(contenido))
            {
                JsonElement raiz = documento.RootElement;

                foreach (JsonElement elemento in raiz.EnumerateArray())
                {
                    string titulo =
                        elemento.GetProperty("titulo").GetString();

                    string artista =
                        elemento.GetProperty("artista").GetString();

                    string genero =
                        elemento.GetProperty("genero").GetString();

                    int duracion =
                        elemento.GetProperty("duracion").GetInt32();

                    Cancion nuevaCancion =
                        new Cancion(
                            titulo,
                            artista,
                            genero,
                            duracion
                        );

                    cola.Encolar(nuevaCancion);

                    arbol.Insertar(nuevaCancion);
                }
            }
    }
}