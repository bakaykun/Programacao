using System;


namespace SextaAula
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValTotEst() 
        {
            return Preco*Quantidade;
        }

        public void AdcionarProduto(int quantidade) 
        {
            Quantidade+=quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade-=quantidade;
        } 

        public override string ToString()
        {
            return $" Dados do produto: {Nome}, R$ {Preco} Quantidade {Quantidade}, Total: R$ {ValTotEst().ToString("F2")}";
        }
    }
}