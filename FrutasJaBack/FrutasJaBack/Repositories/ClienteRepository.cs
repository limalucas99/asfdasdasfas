using FrutasJaBack.Database;
using FrutasJaBack.Models;
using FrutasJaBack.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrutasJaBack.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private Frutascontext _banco;

        public ClienteRepository(Frutascontext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Usuario cliente)
        {
            _banco.Add(cliente);
            _banco.SaveChanges();
        }

        public Usuario Login(string Email, string Senha)
        {
            Usuario cliente = _banco.Clientes.Where(m => m.Email == Email && m.Senha == Senha).FirstOrDefault();
            //FOD - se não encontrar o elemento, retorna nulo, somente o first n faz isso
            return cliente;
        }

        public Usuario ObterCliente(int Id)
        {
            return _banco.Clientes.Find(Id);
        }
    }
}
