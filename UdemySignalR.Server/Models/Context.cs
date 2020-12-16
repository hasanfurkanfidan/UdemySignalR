using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.Server.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS01;Database=SignalRTeam;Integrated Security=true");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Team>Teams  { get; set; }
    }
}
