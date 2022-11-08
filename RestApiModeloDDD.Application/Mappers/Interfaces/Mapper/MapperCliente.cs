using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;


namespace RestApiModeloDDD.Application.Mappers.Interfaces.Mapper
{
    public class MapperCliente : IMapperCliente
    {

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id
                ,Nome = clienteDto.Nome
                ,Sobrenome = clienteDto.SobreNome
                ,Email = clienteDto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id
                ,Nome = cliente.Nome
                ,SobreNome = cliente.Sobrenome 
                ,Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(a => new ClienteDto
            {
                Id = a.Id
                ,Nome = a.Nome
                ,SobreNome = a.Sobrenome
                ,Email = a.Email
            });

            return dto;
        }
    }
}

