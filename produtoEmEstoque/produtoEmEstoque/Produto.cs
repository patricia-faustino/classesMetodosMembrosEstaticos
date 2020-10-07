using System;
using System.Globalization;

namespace produtoEmEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtdd;

        public double ValorEmEstoque()
        {
            return Preco * Qtdd;
        }
        public void Adicionar(int quantidade)
        {
            Qtdd += quantidade;
        }

        public void Remover(int quantidade)
        {
            Qtdd -= quantidade;
        }

        public override string ToString()
        {
            return Nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Qtdd +
                " unidades, Total: " +
                ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
