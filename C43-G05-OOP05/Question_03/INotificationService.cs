using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP05.Question_03
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
