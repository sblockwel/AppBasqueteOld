using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBasquete.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public int Placar { get; set; }
        public int MinimoTemporada { get; set; }
        public int MaximoTemporada { get; set; }
        public int QuebraRecordeMinimo { get; set; }
        public int QuebraRecordeMaximo { get; set; }
        public Jogador Jogador { get; set; } 
    }
}
