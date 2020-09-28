using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutivedadeBasquete.Model;

namespace ProdutivedadeBasquete.Controller
{
    class JogadoraController
    {
        SistemaContext ctx;

        public JogadoraController()
        {
            ctx = new SistemaContext();
        }

        public void CadastrarJogadora(Jogadora item)
        {
            ctx.Jogadoras.Add(item);
            ctx.SaveChanges();
        }

        public List<Jogadora> GetJogadoras()
        {
            return ctx.Jogadoras.ToList();
        }

    }
}
