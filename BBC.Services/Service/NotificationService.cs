using System;
using System.Collections.Generic;
using System.Text;
using BBC.Respositories.IRepositories;
using BBC.Services.IService;

namespace BBC.Services.Service
{
    public class NotificationService : INotificationService
    {
        private INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public IEnumerable<string> GetNotification()
        {
            return _notificationRepository.GetNotification();
        }
    }
}
