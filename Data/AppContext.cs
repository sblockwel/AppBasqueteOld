using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBasquete.Data
{
    class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=c:\mydb.db;Version=3;");
        }
        public virtual DbSet<Jogo> Jogos { get; set; }
    }
}
