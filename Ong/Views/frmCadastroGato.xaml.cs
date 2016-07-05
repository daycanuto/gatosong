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
using Ong.Model;
using Ong.DAL;

namespace Ong.Views
{
    /// <summary>
    /// Interaction logic for frmCadastroGato.xaml
    /// </summary>
    public partial class frmCadastroGato : Window
    {
        private Gato g = new Gato();
        public frmCadastroGato()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {


            g = new Gato();
            g.GatoNome = txtNomeGato.Text;
            g.GatoIdade = txtIdadeGato.Text;
            g.GatoCor = txtCorGato.Text;
            g.GatoStatus =cmbGatoStatus.Text;

            if (GatoDAO.AdicionarGato(g))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Gato",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Gato",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtNomeGato.Clear();
            txtIdadeGato.Text ="";
            txtCorGato.Clear();
            cmbGatoStatus.Text = String.Empty;
            txtNomeGato.Focus();
        }
        private void btnBuscarGatoPorNome_Click(object sender, RoutedEventArgs e)
        {
            g = new Gato();
            if (!string.IsNullOrEmpty(txtBuscarGatoNome.Text))
            {
                g.GatoNome = txtBuscarGatoNome.Text;
                g = GatoDAO.VerificarGatoPorNome(g);
                if (g != null)
                {
                    txtNomeGato.Text = g.GatoNome;
                    txtCorGato.Text = g.GatoCor;
                    txtIdadeGato.Text = g.GatoIdade;
                    cmbGatoStatus.Text = g.GatoStatus;       
                    HabilitarBotoes();
                }
                else
                {
                    MessageBox.Show("Gato não encontrado!", "Cadastro de Gato",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Gato",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public void HabilitarBotoes()
        {
            btnAlterar.IsEnabled = true;
            btnRemover.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnGravar.IsEnabled = false;
        }

        public void DesabilitarBotoes()
        {
            btnAlterar.IsEnabled = false;
            btnRemover.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnGravar.IsEnabled = true;
            txtBuscarGatoNome.Clear();
            txtNomeGato.Clear();
            txtCorGato.Clear();
            txtIdadeGato.Text="";
            cmbGatoStatus.Text=String.Empty;
            txtBuscarGatoNome.Focus();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Cadastro de Gato",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                if (GatoDAO.RemoverGato(g))
                {
                    MessageBox.Show("Gato removido com sucesso", "Cadastra Gato", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Gato não removido!", "Cadastra Gato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Cadastro de Gato",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                g.GatoNome = txtNomeGato.Text;
                g.GatoIdade = txtIdadeGato.Text;
                g.GatoCor = txtCorGato.Text;
                g.GatoStatus = cmbGatoStatus.Text;             
                if (GatoDAO.AlterarGato(g))
                {
                    MessageBox.Show("Gato alterado com sucesso", "Cadastra Gato", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Gato não alterado!", "Cadastra Gato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

        }
    }
}

