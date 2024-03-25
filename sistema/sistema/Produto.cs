using MySql.Data.MySqlClient;
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
        public fmr_Produto()
        {
            InitializeComponent();

        }

        private void Produto_Load(object sender, EventArgs e)
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
