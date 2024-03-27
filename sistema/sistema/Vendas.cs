using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using MeuNamespace.Modelo;



namespace sistema
    {
        public partial class frmVendas : Form
        {
            // Declaração da lista de produtos selecionados
            private List<ProdutoMani> produtosSelecionados;

            public frmVendas()
            {
                InitializeComponent();
            }

            private void GridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void frmVendas_Load(object sender, EventArgs e)
            {

            }


            private void btn_Adicionar_Click(object sender, EventArgs e)
            {
                fmr_Produto fmr = new fmr_Produto();

                // Mostrar o formulário de produtos como um diálogo modal
                DialogResult result = fmr.ShowDialog();

                // Verificar se o usuário confirmou a seleção de produtos
                if (result == DialogResult.OK)
                {
                    // Obter os produtos selecionados do formulário de seleção de produtos
                    produtosSelecionados = fmr.ProdutosSelecionados;

                    // Definir a quantidade de produtos vendidos
                    int quantidadeVendida = CalcularQuantidadeVendida(produtosSelecionados);

                    // Agora você pode chamar o método RegistrarVenda passando os produtos selecionados
                    RegistrarVenda(produtosSelecionados);


                }
            }

            private void RegistrarVenda(List<ProdutoMani> produtos)
            {
                // Defina ou obtenha os valores de quantidadeVendida, vendaParcelada, clienteDaVenda, etc.

                // Inicializar o valor total da venda
                decimal valorTotal = 0;

                // Atualizar o estoque e calcular o valor total da venda
                foreach (var produto in produtos)
                {
                    // Reduzir a quantidade em estoque
                    produto.Quantidade -= 1; // Supondo que sempre será vendida apenas uma unidade de cada produto

                    // Calcular o valor total
                    valorTotal += produto.Preco; // Supondo que Preco é o preço de venda de cada produto
                }

                // Criar uma entrada nas contas a receber
                ContaReceber novaConta = new ContaReceber
                {
                    Cliente = comboBox1.SelectedItem.ToString(), // Supondo que o cliente foi selecionado em um ComboBox
                    Valor = valorTotal,
                    DataVencimento = DateTime.Today.AddDays(30) // Supondo que o prazo de pagamento é de 30 dias
                };

                // Exemplo de uso de EntityState do Entity Framework
                //  EntityState modifiedState = EntityState.Modified;

                // Lógica de registro da venda, incluindo atualização de estoque, contas a receber, etc.

            }
            private int CalcularQuantidadeVendida(List<ProdutoMani> produtos)
            {
                // Aqui você pode implementar a lógica para calcular a quantidade total de produtos vendidos
                // Isso pode ser a soma das quantidades de cada produto na lista de produtos selecionados
                // Por exemplo:
                int quantidadeTotal = 0;
                foreach (var produto in produtos)
                {
                    quantidadeTotal += produto.Quantidade; // Supondo que Produto tenha uma propriedade Quantidade que representa a quantidade vendida
                }
                return quantidadeTotal;
            }
        }
    }



    public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
