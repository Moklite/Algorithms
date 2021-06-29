using System.Collections.Generic;
using System;

namespace All
{
    public class AlertService
    {
        private readonly IAlertDAO _alertDAO;
        //private readonly AlertDAO storage = new AlertDAO();
        AlertService(IAlertDAO alertDAO)
        {
            _alertDAO = alertDAO;
        }
        public Guid RaiseAlert()
        {
            //return this.storage.AddAlert(DateTime.Now);
            return _alertDAO.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            //return this.storage.GetAlert(id);
            return _alertDAO.GetAlert(id);
        }
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly IAlertDAO _alertDAO;
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        AlertDAO(IAlertDAO alertDAO)
        {
            _alertDAO = alertDAO;
        }
        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }

    public interface IAlertDAO
    {
        public Guid AddAlert(DateTime time);
        public DateTime GetAlert(Guid id);
    }
}