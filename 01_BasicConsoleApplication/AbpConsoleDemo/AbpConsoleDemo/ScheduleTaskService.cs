using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpConsoleDemo
{
    public class ScheduleTaskService: ITransientDependency
    {
        //ITransientDependency abp会按Transient为生命周期自动注入

        public async Task ExcuteTask()
        {
           await Task.Run(Action);
        }

        private void Action()
        {
            Enumerable.Range(1, 100).ToList().ForEach((i) =>
            {
                Console.WriteLine($"task running {i}");
                Thread.Sleep(20);
            });
        }
    }
}
