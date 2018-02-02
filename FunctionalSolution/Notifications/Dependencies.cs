using System;
using Notifications.Channel;
using Notifications.Implementation;

namespace Notifications
{
    public static class Dependencies
    {
        public static void AddNotifications(
            Action<Type, Type> addTransient,
            Action<Type, Type> addSingleton)
        {
            addSingleton(typeof(INotifier), typeof(Notifier));
            addTransient(typeof(IEmail), typeof(Email));
        }
    }
}
