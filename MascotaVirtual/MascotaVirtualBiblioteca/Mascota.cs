using System;

namespace MascotaVirtualBiblioteca
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Felicidad { get; private set; }
        public string Estado { get; private set; }

        public Mascota(string nombre)
        {
            Nombre = string.IsNullOrWhiteSpace(nombre) ? "Pipo" : nombre.Trim();
            Felicidad = 50;
            ActualizarEstado();
        }

        void ActualizarEstado()
        {
            if (Felicidad <= 20) Estado = "Hambrienta";
            else if (Felicidad <= 40) Estado = "Aburrida";
            else Estado = "Contenta";
        }

        public void Jugar()
        {
            Felicidad = Math.Min(100, Felicidad + 10);
            Console.WriteLine($"{Nombre} jugó y se divirtió 🎾");
            ActualizarEstado();
        }

        public void Comer()
        {
            Felicidad = Math.Min(100, Felicidad + 8);
            Console.WriteLine($"{Nombre} comió y se siente mejor 🍗");
            ActualizarEstado();
        }

        public void PasarTiempo()
        {
            Felicidad = Math.Max(0, Felicidad - 12);
            Console.WriteLine($"Pasó el tiempo... {Nombre} cambia un poco.");
            ActualizarEstado();
        }

        public override string ToString()
        {
            return $"{Nombre} está {Estado} (felicidad: {Felicidad})";
        }
    }
}