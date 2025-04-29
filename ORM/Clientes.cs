using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Clientes
    {
        public string nome { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }

        private Clientes() {}
        public Clientes(string nome, int cpf)
        {
            nome = nome;
            cpf = cpf;
        }

        public override string ToString()
        {
            return $"{nome} {cpf}";
        }
    }
}
