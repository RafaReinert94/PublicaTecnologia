using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutivedadeBasquete.Model
{
    public class Jogos
    {
        [Key]
        public int Id { get; set; }
        public int IdJogadora { get; set; }
        public int NumJogo { get; set; }
        public int Placar { get; set; }
        public int QtidadeMinimaPontos { get; set; }
        public int QtidadeMaximaPontos { get; set; }
        public int RecordeMinimoPontos { get; set; }
        public int RecordeMaximoPontos { get; set; }


    }
}
