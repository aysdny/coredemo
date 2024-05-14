using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            //var values = nm.GetList();
            //return View(values);
            var values = nm.GetList().Where(x => x.NotificationStatus == true).ToList();
            return View(values);
        }
    }
}

