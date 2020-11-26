using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREM3_CodeFirst.Models
{
    public class ERPDBContext: DbContext
    {
        public ERPDBContext(DbContextOptions<ERPDBContext> options) : base(options) { 
        
        
        
        }

        public DbSet<Persona> Personas { get; set; }

        
    }
}
