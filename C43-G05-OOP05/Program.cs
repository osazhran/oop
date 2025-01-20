using C43_G05_OOP05.Question_01;
using C43_G05_OOP05.Question_02;
using C43_G05_OOP05.Question_03;
using System.Security.Cryptography;

namespace C43_G05_OOP05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            Cicale cicale = new Cicale(10);
            cicale.DisplayShapeInfo();
            Console.WriteLine($"And Area = {cicale.Area}");

            Rectangle rectangle = new Rectangle(20);
            rectangle.DisplayShapeInfo();
            Console.WriteLine($"And Area ={rectangle.Area}");
            #endregion
            #region Q2
            //BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService("osama","pas123", "DBA");
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "osama";
            string password = "pas123";
            string role = "DBA";


            if (authService.AuthenticateUser(username, password))

            {
                Console.WriteLine($"{username} authenticated successfully.");

                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine($"{username} is authorized as {role}.");
                }
                else
                {
                    Console.WriteLine($"You Are Not authorized.");
                }

            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

            #endregion
            #region Q3
            INotificationService notificationServiceEmail = new EmailNotificationService();
            INotificationService notificationServicePush= new PushNotificationService();
            INotificationService notificationServiceSms = new SmsNotificationService();
            notificationServiceEmail.SendNotification("osama@gmail.com", "heloo Mr osama");
            notificationServiceSms.SendNotification("01017622757", "heloo zhran");
            notificationServicePush.SendNotification("Decive13", " Samamsong");

            #endregion
        }
    }
}
