using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ong.Views
{
    public partial class frmCor : Form
    {
        public frmCor()
        {
            InitializeComponent();
        }

        private void frmCor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBanco.Gato' table. You can move, or remove it, as needed.
            this.gatoTableAdapter.Fill(this.dsBanco.Gato);

            this.reportViewer1.RefreshReport();
        }
    }
}
