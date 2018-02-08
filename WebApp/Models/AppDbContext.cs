using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppDbContext : IdentityDbContext<AppUser,IdentityRole,string>
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }


        //public DbSet<Persona> Personas { get; set;}



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Doctor>();
            builder.Entity<Paciente>();
            builder.Entity<Empleado>();
            base.OnModelCreating(builder);
        }

    }//de la clase
}
