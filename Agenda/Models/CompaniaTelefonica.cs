using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class CompaniaTelefonica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCompaniaTelefonica { get; set; }
        public string NombreCompania { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Contacto Contacto { get; set; }
    }
}
