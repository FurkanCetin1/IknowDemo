using IknowDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IknowDemo.DataAccess
{
    public class AgendaDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=FURKAN;Database=AgendaDb;User Id=furkan;Password=1234;TrustServerCertificate=True;");
        }

        public DbSet<AgendaItem> AgendaItems{ get; set; }
        public DbSet<UserCred> UserCreds { get; set; }
    }
}
