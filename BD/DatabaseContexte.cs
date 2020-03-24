using Microsoft.EntityFrameworkCore;
using ProjectMohan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMohan.BD
{
    public class DatabaseContexte : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
        public DbSet<Nouvelle> Nouvelles { get; set; }

    }
}
