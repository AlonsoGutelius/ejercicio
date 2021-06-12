using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ejercicio.Models;
using Microsoft.EntityFrameworkCore;

namespace ejercicio.Controllers
{
    public class HomeController : Controller
    {
       private readonly BuscoContext _context;

        public HomeController(BuscoContext context)
        {
            _context= context;
        }

        public IActionResult Index()
        {
             var productos= _context.Productos.Include(x => x.Categoria).Where(x =>x.FechaRegistro.AddDays(5) > DateTime.Now).ToList();
            return View(productos);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
