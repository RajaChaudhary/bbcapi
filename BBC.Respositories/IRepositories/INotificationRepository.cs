using System;
using System.Collections.Generic;
using System.Text;

namespace BBC.Respositories.IRepositories
{
    public interface INotificationRepository
    {
        IEnumerable<string> GetNotification();
    }
}
