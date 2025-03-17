using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> catalogo = new List<string>
        {
            "National Geographic",
            "Time",
            "Forbes",
            "Scientific American",
            "The Economist",
            "Nature",
            "Popular Science",
            "MIT Technology Review",
            "Wired",
            "Harvard Business Review"
        };

        while (true)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el título a buscar: ");
                string tituloBuscar = Console.ReadLine();
                bool encontrado = BusquedaRecursiva(catalogo, tituloBuscar, 0);

                if (encontrado)
                    Console.WriteLine("Resultado: Encontrado");
                else
                    Console.WriteLine("Resultado: No encontrado");
            }
            else if (opcion == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
            }
        }
    }

    static bool BusquedaRecursiva(List<string> lista, string titulo, int index)
    {
        if (index >= lista.Count)
            return false;

        if (lista[index].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true;

        return BusquedaRecursiva(lista, titulo, index + 1);
    }
}