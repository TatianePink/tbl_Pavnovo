using MeuNamespace.Modelo;
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
    public partial class fmr_Produto : Form
    {
        public List<ProdutoMani> ProdutosSelecionados { get; private set; }
        public fmr_Produto()
        {
            InitializeComponent();
            ProdutosSelecionados = new List<ProdutoMani>();
        }

        private void fmr_Produto_Load(object sender, EventArgs e)
        {

        }

        private void btn_NovoP_Click(object sender, EventArgs e)
        {
            // Adicione os produtos selecionados à lista ProdutosSelecionados
            foreach (DataGridViewRow row in GridProdutos.SelectedRows)
            {
                ProdutoMani produto = (ProdutoMani)row.DataBoundItem;
                ProdutosSelecionados.Add(produto);
            }

            // Feche o formulário
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_AlterarP_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExcluirP_Click(object sender, EventArgs e)
        {

        }

        private void btn_CancelarP_Click(object sender, EventArgs e)
        {

        }
    }
}
