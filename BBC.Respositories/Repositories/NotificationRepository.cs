using System;
using System.Collections.Generic;
using System.Text;
using BBC.Data;
using BBC.Data.Models;
using BBC.Respositories.IRepositories;

namespace BBC.Respositories.Repositories
{
    public class NotificationRepository : INotificationRepository
    {

        public NotificationRepository(BBCDbContext context) 
        {
        }

        public IEnumerable<string> GetNotification()
        {
            List<string> notifications= new List<string>();
            notifications.Add("Notification 1");
            notifications.Add("Notification 2");
            notifications.Add("Notification 3");

            return notifications;
        }
    }
}
