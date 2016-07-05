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
    /// Interaction logic for frmCadastroAdotante.xaml
    /// </summary>
    public partial class frmCadastroAdotante : Window
    {
        private Adotante a = new Adotante();
        public frmCadastroAdotante()
        {
            InitializeComponent();
            DesabilitarBotoes();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            a = new Adotante();
            a.AdotanteNome = txtNomeAdotante.Text;
            a.AdotanteCpf = txtCPFAdotante.Text;
            a.AdotanteIdade = txtIdade.Text;
            a.AdotanteTelefone = txtTelefoneAdotante.Text;
            a.AdotanteEndereço = txtEndereço.Text;
            if (AdotanteDAO.AdicionarAdotante(a))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Adotante",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Adotante",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtNomeAdotante.Clear();
            txtCPFAdotante.Clear();
            txtIdade.Text ="";
            txtTelefoneAdotante.Clear();
            txtEndereço.Clear();
            txtNomeAdotante.Focus();
        }
        private void btnBuscarAdotantePorCpf_Click(object sender, RoutedEventArgs e)
        {
            a = new Adotante();
            if (!string.IsNullOrEmpty(txtBuscarAdotantePorCpf.Text))
            {
                a.AdotanteCpf = txtBuscarAdotantePorCpf.Text;
                a = AdotanteDAO.VerificarAdotantePorCPF(a);
                if (a != null)
                {
                    txtNomeAdotante.Text = a.AdotanteNome;
                    txtCPFAdotante.Text = a.AdotanteCpf;
                    txtTelefoneAdotante.Text = a.AdotanteTelefone;
                    txtIdade.Text = a.AdotanteIdade;
                    txtEndereço.Text = a.AdotanteEndereço;
                    HabilitarBotoes();
                }
                else
                {
                    MessageBox.Show("Adotante não encontrado!", "Cadastro de Adotante",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Adotante",
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
            txtBuscarAdotantePorCpf.Clear();
            txtCPFAdotante.Clear();
            txtNomeAdotante.Clear();
            txtTelefoneAdotante.Clear();
            txtIdade.Text = "";
            txtEndereço.Clear();
            txtBuscarAdotantePorCpf.Focus();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Cadastro de Adotante",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                if (AdotanteDAO.RemoverAdotante(a))
                {
                    MessageBox.Show("Adotante removido com sucesso", "Cadastra Adotante", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Adotante não removido!", "Cadastra Adotante", MessageBoxButton.OK, MessageBoxImage.Error);
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
            if (MessageBox.Show("Deseja alterar o registro?", "Cadastro de Adotante",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                a.AdotanteNome = txtNomeAdotante.Text;
                a.AdotanteCpf = txtCPFAdotante.Text;
                a.AdotanteTelefone = txtTelefoneAdotante.Text;
                a.AdotanteEndereço = txtEndereço.Text;
                a.AdotanteIdade = txtIdade.Text;
                if (AdotanteDAO.AlterarAdotante(a))
                {
                    MessageBox.Show("Adotante alterado com sucesso", "Cadastra Adotante", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Adotante não alterado!", "Cadastra Adotante", MessageBoxButton.OK, MessageBoxImage.Error);
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
