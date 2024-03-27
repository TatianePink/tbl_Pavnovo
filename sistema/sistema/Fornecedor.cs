using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_Fornecedor : Form
    {
        public frm_Fornecedor()
        {
            InitializeComponent();
        }

        private void btn_SalvarF_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeF.Text;
            string endereco = textBoxEnderecoF.Text;
            string telefone = textBoxTelefoneF.Text;

            MessageBox.Show("Fornecedor salvo com sucesso!");

        }

        private void txt_categoria_Click(object sender, EventArgs e)
        {

        }
    }
}
