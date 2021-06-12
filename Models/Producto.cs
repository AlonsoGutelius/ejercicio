using System;
using System.ComponentModel.DataAnnotations;

namespace ejercicio.Models
{
    public class Producto
    {
        
        public int Id {get;set; }
        [Required]
        public string Nombre {get;set; }
        [Required]
        [Display (Name = "Nombre del comprador")]
        public string NombreComprador {get;set; }
        [Required]
        [Display (Name = " Celular del comprador")]
        public string CelularComprador {get;set; }
        [Required]
        [Display (Name = " Lugar de compra")]
        public string LugarCompra {get;set; }
        [Required]
        public string Descripcion {get;set; }
        [Required]
        public string Foto {get;set;}
        [Required]
        public decimal Precio {get;set; }
        public DateTime FechaRegistro{get;set; }
        public Categoria Categoria {get;set; }
        public int CategoriaId{get;set; }
        public Producto(){
            FechaRegistro=DateTime.Now;

        }
    }
}