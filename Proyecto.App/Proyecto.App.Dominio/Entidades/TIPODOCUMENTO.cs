using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class TipoDocumento
    {
        [Key]
        public int tipoDocumentoId { get; set; }
        public string descripcion {get; set; }
        public List<Usuarios> Usuarios {get;set;}
    }

}