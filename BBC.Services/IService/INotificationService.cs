using System;
using System.Collections.Generic;
using System.Text;

namespace BBC.Services.IService
{
    public interface INotificationService
    {
        IEnumerable<string> GetNotification();
    }
}
