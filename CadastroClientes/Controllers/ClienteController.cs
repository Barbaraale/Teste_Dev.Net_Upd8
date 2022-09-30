using CadastroClientes.Models;
using CadastroClientes.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var clientes = _clienteRepository.GetAll();
            return View(clientes);
        }

        public IActionResult Editar(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            return View(cliente);
        }

        public IActionResult Deletar(int id)
        {
            _clienteRepository.Delete(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Create(ClienteModel cliente)
        {
            _clienteRepository.Create(cliente);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Update(ClienteModel cliente)
        {
            _clienteRepository.Update(cliente);
            return RedirectToAction("Listar");
        }
    }
}
