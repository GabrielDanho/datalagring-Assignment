using datalagring.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalagring.data
{
    public class ÄrendeContext : DbContext
    {
        public DbSet<Ärende> Ärenden { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB\Databases;Initial Catalog=MyDb;Integrated Security=True;");
        }
    
    }
}
