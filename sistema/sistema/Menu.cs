﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema
{
    public partial class fmr_Menu : Form
    {
        
        public fmr_Menu()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cad_produto_Click(object sender, EventArgs e)
        {
            fmr_Produto frm = new fmr_Produto();
            frm.Show();
        }

        private void btn_cad_categoria_Click(object sender, EventArgs e)
        {
            frm_Categorias frm = new frm_Categorias();
            frm.Show();
        }

        private void btn_cad_fornecedor_Click(object sender, EventArgs e)
        {
            frm_Fornecedor frm = new frm_Fornecedor();
            frm.Show();
        }

        private void butbtn_cad_cliente_Click(object sender, EventArgs e)
        {
            fmr_Cliente2 frm = new fmr_Cliente2();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_Produto frm = new fmr_Produto();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_Cliente2 frm = new fmr_Cliente2();
            frm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Fornecedor frm = new frm_Fornecedor();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categorias frm = new frm_Categorias();
            frm.Show();
        }

<<<<<<< HEAD
=======
       

>>>>>>> 76bb51fcd22960b85fb70b20bf961e3ccf2f755b
        private void fmr_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = ("server=localhost;uid=root;pwd=123456;database=pavbanco");
                var conexao = new MySqlConnection(strConexao);
<<<<<<< HEAD
            }
                conexao.Open();
            MessageBox.Show("tudo certo");

        }
        Catch(Exception ex)
        {
            MessageBox.Show("ocorreu um erro" + ex.Message);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVendas frm = new frmVendas();
            frm.Show();
        }
=======
                conexao.Open();
                MessageBox.Show("tudo certo");




            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }


        }

>>>>>>> 76bb51fcd22960b85fb70b20bf961e3ccf2f755b
    }
    
}
//frm = new();frm.Show();
