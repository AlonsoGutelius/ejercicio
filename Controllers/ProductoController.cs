using System.Linq;
using ejercicio.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ejercicio.Controllers
{
    public class ProductoController : Controller    
    {
       private readonly BuscoContext _context;
       public ProductoController(BuscoContext context){
           _context = context;
       }       
       [Authorize]
       public IActionResult Registro(){
           ViewBag.Categorias = _context.Categorias.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
           return View();
       }
       [HttpPost]
       public IActionResult Registro(Producto p){
           if(ModelState.IsValid){
               _context.Productos.Add(p);
               _context.SaveChanges();
               return RedirectToAction("Index", "Home");
           } else{
               return View(p);
           }
       }
    }
}