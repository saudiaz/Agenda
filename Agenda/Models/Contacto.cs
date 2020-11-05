using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDContracto { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int NumeroContacto { get; set; }
        public int IDCompaniaTelefonica { get; set; }
        public virtual CompaniaTelefonica CompaniaTelefonica { get; set; }
     //   public Guid IdUser { get; set; }
        [ForeignKey("Id")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
