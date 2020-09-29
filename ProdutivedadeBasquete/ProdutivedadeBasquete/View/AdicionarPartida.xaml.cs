using ProdutivedadeBasquete.Controller;
using ProdutivedadeBasquete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProdutivedadeBasquete.View
{
    /// <summary>
    /// Lógica interna para AdicionarPartida.xaml
    /// </summary>
    public partial class AdicionarPartida : Window
    {
        public AdicionarPartida()
        {
            InitializeComponent();

            List<Jogadora> jogadoras = new JogadoraController().GetJogadoras();
            cbxJogadora.ItemsSource = jogadoras.Select(x => x.Nome);
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

            new PartidaController().CadastrarPartida(new Partida()
            {
                IdJogadora = cbxJogadora.SelectedIndex,
                NumJogo = Int16.Parse(tbxJogo.Text),
                Placar = Int16.Parse(tbxPontos.Text),
                QtidadeMinimaPontos = new PartidaController().QuantidadeMinima(cbxJogadora.SelectedIndex, Int16.Parse(tbxPontos.Text)),
                QtidadeMaximaPontos = new PartidaController().QuantidadeMaxima(cbxJogadora.SelectedIndex, Int16.Parse(tbxPontos.Text)),
                RecordeMinimoPontos = new PartidaController().QuebraRecordeMinimo(cbxJogadora.SelectedIndex, Int16.Parse(tbxPontos.Text)),
                RecordeMaximoPontos = new PartidaController().QuebraRecordeMaximo(cbxJogadora.SelectedIndex, Int16.Parse(tbxPontos.Text))
            }) ;

            this.Close();
        }

        

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
