using ejercicio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ejercicio.Controllers
{
    public class BuscoContext : IdentityDbContext
    {
        public DbSet<Producto> Productos {get;set; }
        public DbSet<Categoria> Categorias {get;set;}
        public BuscoContext(DbContextOptions dco) : base(dco){

        }
    }
}