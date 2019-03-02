using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBC.Services.IService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBC.API.Controllers
{
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private INotificationService _notificationService;
        public NotificationController(INotificationService notificationService )
        {
            _notificationService = notificationService;
        }

        // Get notification: api/<controller>
        [HttpGet]
        public IEnumerable<string> GetNotification()
        {
            return _notificationService.GetNotification();
        }

    }
}
