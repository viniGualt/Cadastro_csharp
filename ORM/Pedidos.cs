using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Pedidos
    {
        Produtos produto { get; set; }
        Clientes cliente { get; set; }
        DateTime data { get; set; }
        double valorTotal { get; set; }
    }
}
