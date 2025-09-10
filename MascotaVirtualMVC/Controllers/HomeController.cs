using Microsoft.AspNetCore.Mvc;
using MascotaVirtualBiblioteca;

namespace MascotaVirtualMVC.Controllers
{
    public class MascotaController : Controller
    {
        // Mascota en memoria para toda la app (estático por ahora).
        private static Mascota _miMascota = new Mascota("Pipo");

        public IActionResult Index()
        {
            return View(_miMascota);
        }

        public IActionResult Jugar()
        {
            _miMascota.Jugar();
            return RedirectToAction("Index");
        }

        public IActionResult Comer()
        {
            _miMascota.Comer();
            return RedirectToAction("Index");
        }

        public IActionResult PasarTiempo()
        {
            _miMascota.PasarTiempo();
            return RedirectToAction("Index");
        }
    }
}
