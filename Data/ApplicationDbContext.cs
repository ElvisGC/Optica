using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Optica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Optica.Models.Citas> Citas {get; set;} 
        public DbSet<Optica.Models.Contactanos> Contactanos { get; set; }
        public DbSet<Optica.Models.Productos> Productos { get; set; }
        public DbSet<Optica.Models.Proforma> Carrito { get; set; }
    }
}





