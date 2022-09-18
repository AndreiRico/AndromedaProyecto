using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class RH
    {
        [Key]
        public int rhId { get; set; }
        [MaxLength(3)]
        public string descripcion {get; set; }
        public List<Usuarios> Usuarios {get;set;}
    }

}