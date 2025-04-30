using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Produtos
    {
        public string nome { get; set; }
        public double preco { get; set; }

        private Produtos() { }
        public Produtos(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

    }
}