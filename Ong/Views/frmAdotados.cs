﻿using System;
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
    public partial class frmAdotados : Form
    {
        public frmAdotados()
        {
            InitializeComponent();
        }

        private void frmAdotados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBanco.dsAdocaoStatus' table. You can move, or remove it, as needed.
            this.dsAdocaoStatusTableAdapter.Fill(this.dsBanco.dsAdocaoStatus);

            this.reportViewer1.RefreshReport();
        }
    }
}
