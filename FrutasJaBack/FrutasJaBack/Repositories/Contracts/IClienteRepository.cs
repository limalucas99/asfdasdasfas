using FrutasJaBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrutasJaBack.Repositories.Contracts
{
    public interface IClienteRepository
    {
        Usuario Login(string Email, string Senha);

        void Cadastrar(Usuario cliente);

        Usuario ObterCliente(int id);

    }
}
