using System;
using System.Globalization;

namespace produtoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Qtdd = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.Adicionar(quantidade);
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.Remover(quantidade);
            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}
