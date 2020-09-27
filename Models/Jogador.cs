using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBasquete.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Jogo> Jogos { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
