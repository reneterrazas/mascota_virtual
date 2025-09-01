using System;
using MascotaVirtualBiblioteca;

namespace MascotaVirtualConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("🐾 Bienvenido a la Mascota Virtual (Consola) 🐾");
            Console.Write("Ingresa el nombre de tu mascota: ");
            string nombre = Console.ReadLine()?.Trim() ?? "Pipo";
            if (string.IsNullOrWhiteSpace(nombre)) nombre = "Pipo";

            Mascota miMascota = new Mascota(nombre);

            int opcion = -1;
            do
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1 - Jugar");
                Console.WriteLine("2 - Comer");
                Console.WriteLine("3 - Pasar tiempo");
                Console.WriteLine("4 - Ver estado");
                Console.WriteLine("0 - Salir");
                Console.Write("Elige una opción: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out opcion))
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        miMascota.Jugar();
                        break;
                    case 2:
                        miMascota.Comer();
                        break;
                    case 3:
                        miMascota.PasarTiempo();
                        break;
                    case 4:
                        Console.WriteLine(miMascota);
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta luego! 👋");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}