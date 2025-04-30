using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Pedidos
    {
        public int id { get; set; }
        public List<Produtos> produtos { get; set; }
        public Clientes cliente { get; set; }
        public DateTime data { get; set; }

        private Pedidos() { }
        public Pedidos(List<Produtos> produtos, Clientes cliente, DateTime data)
        {
            this.produtos = produtos;
            this.cliente = cliente;
            this.data = data;
        }

        public decimal ValorTotal = 0;

        public decimal CalcularValorTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.preco;
            }
            return total;
        }
    }
}
