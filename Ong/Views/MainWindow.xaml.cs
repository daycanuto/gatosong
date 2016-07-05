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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ong.Views;

namespace Ong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuCadastroGato_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroGato frmCadastroGato = new frmCadastroGato();
            frmCadastroGato.ShowDialog();
        }

        private void menuCadastroAdotante_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroAdotante frmCadastroAdotante = new frmCadastroAdotante();
            frmCadastroAdotante.ShowDialog();
        }

        private void menuAdocao_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroAdocao frmCadastroAdocao = new frmCadastroAdocao();
            frmCadastroAdocao.ShowDialog();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo...",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void RelatorioAdotados_Click(object sender, RoutedEventArgs e)
        {
            frmAdotados relatorio = new frmAdotados();
            relatorio.ShowDialog();
        }

        private void RelatorioCor_Click(object sender, RoutedEventArgs e)
        {
            frmCor relatorio = new frmCor();
            relatorio.ShowDialog();
        }

        private void RelatorioIdade_Click(object sender, RoutedEventArgs e)
        {
            frmIdade relatorio = new frmIdade();
            relatorio.ShowDialog();
        }
    }
}


