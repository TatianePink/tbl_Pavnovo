<<<<<<< HEAD
﻿using MeuNamespace.Modelo;
=======
﻿using MySql.Data.MySqlClient;
>>>>>>> 76bb51fcd22960b85fb70b20bf961e3ccf2f755b
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


namespace sistema
{
    public partial class fmr_Produto : Form
    {
        public List<ProdutoMani> ProdutosSelecionados { get; private set; }
        public fmr_Produto()
        {
            InitializeComponent();
<<<<<<< HEAD
            ProdutosSelecionados = new List<ProdutoMani>();
=======

>>>>>>> 76bb51fcd22960b85fb70b20bf961e3ccf2f755b
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
            try
            {
                var strConexao = ("server=localhost;uid=root;pwd=123456;database=pavbanco");
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void btn_CadastrarP_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ExcluirP_Click(object sender, EventArgs e)
        {

        }

         

        private void btn_CancelarP_Click(object sender, EventArgs e)
        {

        }

        private void btn_NovoP_Click(object sender, EventArgs e)
        {

        }
    }
}
