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

        public void CadastrarPartida(Partida item)
        {
            ctx.Partidas.Add(item);
            ctx.SaveChanges();
        }

        public int QuantidadeMinima(int idJogadora, int pontos)
        {

            if (ctx.Partidas.Select(x => x.IdJogadora).Contains(idJogadora))
            {
                int registroJogadora = ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.QtidadeMinimaPontos).Min();
                if (pontos < registroJogadora)
                {
                    return pontos;
                }
                else
                {
                    return registroJogadora;
                }

            }
            else
            {
                return pontos;
            }
        }


        public int QuantidadeMaxima(int idJogadora, int pontos)
        {

            if (ctx.Partidas.Select(x => x.IdJogadora).Contains(idJogadora))
            {
                int registroJogadora = ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.QtidadeMaximaPontos).Max();
                if (pontos > registroJogadora)
                {
                    return pontos;
                }
                else
                {
                    return registroJogadora;
                }

            }
            else
            {
                return pontos;
            }
        }

        public int QuebraRecordeMinimo(int idJogadora, int pontos)
        {
            
            if (ctx.Partidas.Select(x => x.IdJogadora).Contains(idJogadora))
            {
                int registroJogadora = ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.QtidadeMinimaPontos).Min();
                if (pontos < registroJogadora)
                {
                    return (ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.RecordeMinimoPontos).Max() + 1);
                }
                else
                {
                    return (ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.RecordeMinimoPontos).Max());
                }
            }
            else
            {
                return 0;
            }
        }

        public int QuebraRecordeMaximo(int idJogadora, int pontos)
        {
           
            if (ctx.Partidas.Select(x => x.IdJogadora).Contains(idJogadora))
            {
                int registroJogadora = ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.QtidadeMaximaPontos).Max();
                if (pontos > registroJogadora)
                {
                    return (ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.RecordeMaximoPontos).Max() + 1);
                }
                else
                {
                    return (ctx.Partidas.Where(x => x.IdJogadora == idJogadora).Select(x => x.RecordeMaximoPontos).Max());
                }
            }
            else
            {
                return 0;
            }
        }

        public List<Partida> GetPartidas()
        {
            return ctx.Partidas.ToList();
        }

    }
}
