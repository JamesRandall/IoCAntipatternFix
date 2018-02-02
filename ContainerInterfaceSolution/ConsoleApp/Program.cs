using System;
using Calendar;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IServiceProvider provider = RegisterDependencies();
            // do stuff...
        }

        static IServiceProvider RegisterDependencies()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddCalendar();

            return services.BuildServiceProvider();
        }
    }
}
