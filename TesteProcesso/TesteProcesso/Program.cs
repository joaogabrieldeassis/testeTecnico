

using Microsoft.Extensions.DependencyInjection;
using TesteProcesso;
using TesteProcesso.Interfaces;

namespace MyApp
{
    public static class Program
    {                
        public static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var startProgram = serviceProvider.GetService<IEntradaDoUsuario>();
            startProgram.ReceberAhEntradaDoUsuario();
        }

        public static void ConfigureService(IServiceCollection service)
        {
            service.AddScoped<IEntradaDoUsuario, EntradaDoUsuario>();
            service.AddScoped<ILizard, Lizard>();
            service.AddScoped<IPapel, Papel>();
            service.AddScoped<IPedra, Pedra>();
            service.AddScoped<Ispock, spock>();
            service.AddScoped<ITesoura, Tesoura>();
        }



    }
}