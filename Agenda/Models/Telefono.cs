using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    [Table("Telefono")]
    public class Telefono
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public String Numero { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }

        public Contacto Contacto { get; set; }
        public int ContactoId { get; set; }

    }
}