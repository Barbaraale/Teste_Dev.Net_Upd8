using CadastroClientes.Data;
using CadastroClientes.Models;
using CadastroClientes.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Repository
{
    public class ClienteRopository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;

        public ClienteRopository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ClienteModel> GetAll()
        {
            return _bancoContext.Clientes.ToList();
        }
        public ClienteModel GetById(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public ClienteModel Create(ClienteModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Update(ClienteModel cliente)
        {
            var clienteDB = GetById(cliente.Id);

            if (clienteDB == null)
            {
                throw new SystemException("Erro ao atualizar cliente");
            }
            else
            {
                clienteDB.Nome = cliente.Nome;
                clienteDB.CPF = cliente.CPF;
                clienteDB.DataNascimento = cliente.DataNascimento;
                clienteDB.Sexo = cliente.Sexo;
                clienteDB.Cidade = cliente.Cidade;
                clienteDB.Estado = cliente.Estado;

                _bancoContext.Clientes.Update(clienteDB);
                _bancoContext.SaveChanges();
            }

            return clienteDB;
        }

        public bool Delete(int id)
        {
            var clienteDB = GetById(id);

            if (clienteDB == null)
            {
                throw new SystemException("Erro ao deletar cliente");
            }
            else
            {
                _bancoContext.Clientes.Remove(clienteDB);
                _bancoContext.SaveChanges();
            }

            return true;
        }

    }
}
