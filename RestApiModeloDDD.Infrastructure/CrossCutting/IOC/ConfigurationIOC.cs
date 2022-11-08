using Autofac;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Application.Mappers.Interfaces.Mapper;
using RestApiModeloDDD.Application;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region  IOC

            //Injeção de dependência Cliente
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();



            //Injeção de dependência Produto
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
          

            #endregion

        }
    }
}
