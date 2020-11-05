using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Perfil Perfil { get; set;}
        public virtual ICollection<Contacto> Contactos { get; set; }
    }
}
