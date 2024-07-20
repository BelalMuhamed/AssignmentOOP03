using AssignmentOOP03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{
    internal class EmailNotificationService :INotificationService
    {
        public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Sending Email to {recipient}: {message}");
    }
}
   
}
