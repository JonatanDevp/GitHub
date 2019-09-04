using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Construtor
{
    class Produto
    {
        private string _nome;  //tem um lógica especifica
        public double _preco { get; private set; } //propriedade autoimplementada
        public int Quantidade { get; private set; } 


        public Produto()
        {

        }

        //public Produto(string nome, double preco, int quantidade)  //construtores
        //{
        //    _nome = nome;
        //    _preco = preco;
        //    Quantidade = quantidade;
        //}

        //public Produto(string nome, double preco)
        //{
        //    _nome = nome;
        //    _preco = preco;
        //    Quantidade = 5 ;
        //}

        public string Nome  //propriedade maneira correta de encapsulamento no C#
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if(Preco > 0)
                {
                    _preco = Preco; 
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
