using AssignmentOOP03.Interfaces;

namespace AssignmentOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region P02Q01
             Circle circle = new Circle() { Area=15};
            circle.DispalyShapeInfo();
            Rectangle rectangle = new Rectangle();
            rectangle.DispalyShapeInfo();
            #endregion 

            #region P02Q02
           BasicAuthenticationService authenticationService = new BasicAuthenticationService();
            Console.WriteLine(authenticationService.AuthorizeUser("Bilal", "admin"));
            Console.WriteLine(authenticationService.AuthenticateUser("Bilal", "666666"));
            Console.WriteLine(authenticationService.AuthorizeUser("Bilal", "user"));
            Console.WriteLine(authenticationService.AuthenticateUser("Bilal", "6665266"));
            #endregion

            #region P02Q03
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "user@.com";
            string message = "This is a test notification.";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);
        }
        #endregion
    
    }
}
