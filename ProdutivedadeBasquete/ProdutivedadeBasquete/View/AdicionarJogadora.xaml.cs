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
    /// Lógica interna para AdicionarJogadora.xaml
    /// </summary>
    public partial class AdicionarJogadora : Window
    {
        public AdicionarJogadora()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

            new JogadoraController().CadastrarJogadora(new Jogadora()
            {
                Nome = tbxNome.Text,
                Nascimento = dpkNascimento.SelectedDate.GetValueOrDefault() 
                
            });

            this.Close();

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
