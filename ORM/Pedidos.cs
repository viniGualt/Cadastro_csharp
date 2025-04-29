using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Pedidos
    {
        public int Id { get; set; }
        Produtos produto { get; set; }
        Clientes cliente { get; set; }
        DateTime data { get; set; }
        double valorTotal { get; set; }
        public decimal ValorTotal => CalcularValorTotal();
        private decimal CalcularValorTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preco;
            }
            return total;
        }


    }
}
