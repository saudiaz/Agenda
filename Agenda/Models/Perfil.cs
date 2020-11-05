using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Perfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPerfil { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int NumeroContacto { get; set; }
        
        public int IDCompaniaTelefonica { get; set; }
        public virtual CompaniaTelefonica CompaniaTelefonicas { get; set; }
        public string IdUser { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
