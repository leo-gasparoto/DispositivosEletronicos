using DispositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc; 

namespace DispositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRam = 16,  SistemaOperacional = "Windows 11"  },
                new Computador { Marca = "Sansung", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRam = 16,  SistemaOperacional = "Windows 11"  }
            };
            return View(dispositivos);
        }
    }
}
