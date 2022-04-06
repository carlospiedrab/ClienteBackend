using APIClientes.Modelos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClientes.Repositorio
{
    public interface IClienteRepositorio
    {

        Task<List<ClienteDto>> GetClientes();

        Task<ClienteDto> GetClienteById(int id);

        Task<ClienteDto> CreateUpdate(ClienteDto clienteDto);

        Task<bool> DeleteCliente(int id);

    }
}
