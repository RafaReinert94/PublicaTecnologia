using ProdutivedadeBasquete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutivedadeBasquete.Controller
{
    class PartidaController
    {
        SistemaContext ctx;

        public PartidaController()
        {
            ctx = new SistemaContext();
        }




        public List<Partida> GetPartidas()
        {
            return ctx.Partidas.ToList();
        }

    }
}
