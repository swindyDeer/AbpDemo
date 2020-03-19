using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace AbpConsoleDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CreateHostBuilder().RunConsoleAsync();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext,service)=> {
                //AppHostedService 需要实现 IHostedService
                service.AddHostedService<AppHostedService>();
            });
    }
}
