using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPAndICPHomework
{
    public class AuthorizationServiceBefore
    {
        private IAuthorization _authorization;

        public AuthorizationServiceBefore()
        {
            // Возникает проблема в том что авторизация может быть только через mail
            // и чтобы сменить тип авторизации нужно будет лезть в код
            _authorization = new MailAuthorization();
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
