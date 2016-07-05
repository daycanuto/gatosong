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
    /// Interaction logic for frmCadastroAdocao.xaml
    /// </summary>
    public partial class frmCadastroAdocao : Window
    {
        private Adocao a = new Adocao();
        public frmCadastroAdocao()
        {
            InitializeComponent();
            cbxGato.ItemsSource = GatoDAO.ListarGatoLivres();
            cbxGato.DisplayMemberPath = "GatoNome";
            cbxGato.SelectedValuePath = "GatoId";
            cbxAdotante.ItemsSource = AdotanteDAO.ListarAdotantes();
            cbxAdotante.DisplayMemberPath = "AdotanteNome";
            cbxAdotante.SelectedValuePath = "AdotanteId";
        }

        private void txtNomeAdotante_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNomeGato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bntGravar_Click(object sender, RoutedEventArgs e)
        {
            a = new Adocao();
            a.AdotanteId = (int)cbxAdotante.SelectedValue;
            a.GatoId = (int)cbxGato.SelectedValue;
            
            

            if (AdocaoDAO.AdicionarAdocao(a))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Adoção",
                MessageBoxButton.OK, MessageBoxImage.Information);
                Gato gatoadotado = GatoDAO.VerificarGatoPorId(a.GatoId);
                gatoadotado.GatoStatus = "Adotado";
                GatoDAO.AlterarGato(gatoadotado);
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Adoção",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }


    }
}
