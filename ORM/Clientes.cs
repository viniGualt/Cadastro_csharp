using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Clientes
    {
        public string nome { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }

        private Clientes() { }
        public Clientes(string nome, int cpf, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }

        public override string ToString()
        {
            return $"Nome: {nome} - CPF: {cpf}";
        }
    }
}
