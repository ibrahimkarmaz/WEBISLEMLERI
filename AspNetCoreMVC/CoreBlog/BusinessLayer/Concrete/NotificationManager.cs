using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDAL _notificationDAL;

        public NotificationManager(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }

        public Notification GetById(int id)
        {
            return _notificationDAL.GetById(id);
        }

        public List<Notification> GetList()
        {
            return _notificationDAL.GetListAll();
        }

        public void TAdd(Notification t)
        {
            _notificationDAL.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _notificationDAL.Delete(t);
        }

        public void TUpdate(Notification t)
        {
            _notificationDAL.Update(t);
        }
    }
}
