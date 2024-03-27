using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuNamespace.Modelo
{
    public class ProdutoMani
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        // Adicione a propriedade Quantidade para representar a quantidade vendida
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeFabricacao { get; set; }
        public DateTime DataDeValidade { get; set; }

        public decimal CalcularValorTotal(int quantidade)
        {
            return quantidade * Preco;
        }

        public void AtualizarQuantidadeEmEstoque(int novaQuantidade)
        {
            QuantidadeEmEstoque = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
            Console.WriteLine($"Data de Fabricação: {DataDeFabricacao.ToShortDateString()}");
            Console.WriteLine($"Data de Validade: {DataDeValidade.ToShortDateString()}");
        }
    }
}
