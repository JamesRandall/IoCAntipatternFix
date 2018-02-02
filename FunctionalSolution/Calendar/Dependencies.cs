using System;
using Calendar.DataAccess;
using Calendar.Implementation;

namespace Calendar
{
    public static class Dependencies
    {
        public static void AddCalendar(
            Action<Type, Type> addTransient,
            Action<Type, Type> addSingleton)
        {
            addTransient(typeof(ICalendarRepository), typeof(CalendarRepository));
            addTransient(typeof(ICalendarManager), typeof(CalendarManager));

            Notifications.Dependencies.AddNotifications(addTransient, addSingleton);
        }
    }
}
