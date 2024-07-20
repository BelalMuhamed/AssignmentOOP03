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

        #region part01
        /*
        1- What is the primary purpose of an interface in C#?
         b- To define a blueprint for a class
        2-Which of the following is NOT a valid access modifier for interface members in C#?
         a-private 
        3-Can an interface contain fields in C#?
        b-no
        4-In C#, can an interface inherit from another interface?
        b) Yes, interfaces can inherit from multiple interfaces
        5-Which keyword is used to implement an interface in a class in C#?
         d) implements
        6-Can an interface contain static methods in C#?
         a-yes
        7-In C#, can an interface have explicit access modifiers for its members?
        b) No, all members are implicitly public
        8-What is the purpose of an explicit interface implementation in C#?
        b) To provide a clear separation between interface and class members
        9-In C#, can an interface have a constructor?
        b) No, interfaces cannot have constructors
        10-How can a C# class implement multiple interfaces?
        c) By separating interface names with commas
         */
        #endregion

    }
}
