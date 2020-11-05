using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<CompaniaTelefonica> CompaniaTelefonicas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                   .HasOne(a => a.Perfil)
                   .WithOne(a => a.ApplicationUser)
                   .HasForeignKey<Perfil>(p => p.IdUser);

            builder.Entity<CompaniaTelefonica>()
                   .HasOne(c => c.Perfil)
                   .WithOne(c => c.CompaniaTelefonicas)
                   .HasForeignKey<Perfil>(p => p.IDCompaniaTelefonica);

            builder.Entity<CompaniaTelefonica>()
                   .HasOne(c => c.Contacto)
                   .WithOne(c => c.CompaniaTelefonica)
                   .HasForeignKey<Contacto>(co => co.IDCompaniaTelefonica);

     /*       builder.Entity<Contacto>()
                   .HasOne(c => c.ApplicationUser)
                   .WithMany(a => a.Contactos)
                   .HasForeignKey<Contacto>(c => c.IdUser); */
                   



        }

    }
}
