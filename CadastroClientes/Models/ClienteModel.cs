using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public char Sexo { get; set; }
    }
}
