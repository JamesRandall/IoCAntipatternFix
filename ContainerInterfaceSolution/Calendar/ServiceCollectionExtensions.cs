using Calendar.DataAccess;
using Calendar.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Notifications;

namespace Calendar
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCalendar(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICalendarRepository, CalendarRepository>();
            serviceCollection.AddTransient<ICalendarManager, CalendarManager>();

            serviceCollection.AddNotifications();

            return serviceCollection;
        }
    }
}
