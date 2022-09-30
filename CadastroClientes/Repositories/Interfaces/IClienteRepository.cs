using CadastroClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        List<ClienteModel> GetAll();
        ClienteModel GetById(int id);
        ClienteModel Create(ClienteModel cliente);
        ClienteModel Update(ClienteModel cliente);
        bool Delete(int id);
    }
}
