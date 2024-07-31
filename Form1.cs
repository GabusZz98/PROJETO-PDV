using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MenuFuncionário_Click(object sender, EventArgs e) {
            cadastros.FrmCadFuncionario frm = new cadastros.FrmCadFuncionario();
            frm.ShowDialog();
        }
    }
}
