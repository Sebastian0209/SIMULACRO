using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{


    public enum TipoVenta
    {
        Alimentos,
        Productos,
        Bebidas
    }
    public enum TipoEstado
    {
        Activo,
        Inactivo
    }

    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }

        [Required]
        public string Nombre  { get; set; }

        [Required]
        public decimal PrecioVenta { get; set; }

        [Required]
        public TipoVenta Ventas{ get; set; }

        [Required]
        public TipoEstado Estado { get; set; }













    }
}