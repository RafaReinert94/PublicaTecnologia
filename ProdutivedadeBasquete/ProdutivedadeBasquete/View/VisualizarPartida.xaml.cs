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
using ProdutivedadeBasquete.Model;
using ProdutivedadeBasquete.Controller;

namespace ProdutivedadeBasquete.View
{
    /// <summary>
    /// Lógica interna para VisualizarPartida.xaml
    /// </summary>
    public partial class VisualizarPartida : Window
    {

        JogadoraController Jogadora = new JogadoraController();
        PartidaController Partida = new PartidaController();

        public VisualizarPartida()
        {
            InitializeComponent();

            var jogadoras = Jogadora.GetJogadoras();
            var partidas = Partida.GetPartidas();


            dataGrid.ItemsSource = (from part in partidas
                                    join jog in jogadoras on part.IdJogadora equals jog.Id
                                    select new
                                    {
                                        Jogo = part.NumJogo,
                                        Jogadora = jog.Nome,
                                        Placar = part.Placar,
                                        MinimoDaTemporada = part.QtidadeMinimaPontos,
                                        MaximaDaTemporada = part.QtidadeMinimaPontos,
                                        QuebraRecordeMinimo = part.RecordeMinimoPontos,
                                        QuebraRecordeMaximo = part.RecordeMaximoPontos

                                    }).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
