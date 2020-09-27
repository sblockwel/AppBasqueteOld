using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBasquete.Data
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=Basquete;Uid=Dev;Pwd=123456;");
        }
        public virtual DbSet<Jogo> Jogos { get; set; }
        public virtual DbSet<Jogador> Jogadores { get; set; }
    }
}
