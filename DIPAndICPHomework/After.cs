using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class AuthorizationServiceBefore
    {
        private IAuthorization _authorization;

        public AuthorizationServiceBefore(IAuthorization authorization)
        {
            // В данном случае можно использовать любой тип авторизации 
            _authorization = authorization;
        }

        public void LogIn()
        {
            _authorization.LogIn();
        }

    }

    public interface IAuthorization
    {
        void LogIn();
    }

    public class GoogleAuthorization : IAuthorization
    {
        public void LogIn()
        {
            Console.WriteLine("GoogleAuthorization");
        }
    }

    public class TelegramAuthorization : IAuthorization
    {
        public void LogIn()
        {
            Console.WriteLine("TelegramAuthorization");
        }
    }

    public class MailAuthorization : IAuthorization
    {
        public void LogIn()
        {
            Console.WriteLine("MailAuthorization");
        }
    }
}
