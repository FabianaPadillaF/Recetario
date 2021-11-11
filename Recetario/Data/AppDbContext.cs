using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recetario.Models;

namespace Recetario.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Recetario.Models.Departamento> Departamento { get; set; }
        public DbSet<Recetario.Models.Receta> Receta { get; set; }
    }
}

