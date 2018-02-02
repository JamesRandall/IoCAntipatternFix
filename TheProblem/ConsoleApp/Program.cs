using System;
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
            services.AddTransient<Calendar.DataAccess.ICalendarRepository, Calendar.DataAccess.CalendarRepository>();
            services.AddTransient<Calendar.ICalendarManager, Calendar.CalendarManager>();
            services.AddSingleton<Notifications.INotifier, Notifications.Notifier>();
            services.AddTransient<Notifications.Channel.IEmail, Notifications.Channel.Email>();

            return services.BuildServiceProvider();
        }
    }
}
