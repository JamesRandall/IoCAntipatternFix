using Microsoft.Extensions.DependencyInjection;
using Notifications.Channel;
using Notifications.Implementation;

namespace Notifications
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNotifications(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<INotifier, Notifier>();
            serviceCollection.AddTransient<IEmail, Email>();
            return serviceCollection;
        }
    }
}
