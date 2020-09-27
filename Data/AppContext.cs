using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBasquete.Data
{
    class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\mydb.db;");
        }
        public virtual DbSet<Jogo> Jogos { get; set; }
    }
}
