using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;

namespace AbpConsoleDemo
{
    public class AppHostedService : IHostedService
    {
        //IHostedService 用于实现后台任务 需要实现方法 StartAsync StopAsync

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var application = AbpApplicationFactory.Create<AppModule>(options => { options.UseAutofac(); }))
            {
                application.Initialize();

                var scheduleTask = application.ServiceProvider.GetService<ScheduleTaskService>();
                await scheduleTask.ExcuteTask();

                application.Shutdown();
            }

            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
