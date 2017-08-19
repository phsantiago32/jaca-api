using System;
using Jaca.Api.Managers.Interfaces;
using Jaca.Api.Models.Response;
using MimeKit;
using MailKit.Net.Smtp;
using Jaca.Api.Models;

namespace Jaca.Api.Managers
{
    public class AuthenticationManager : BaseManager, IAuthenticationManager
    {
        public BaseResponse<object> IsValidLogin(string login, string password)
        {
            var response = new BaseResponse<object>();

            var isValidLogin = this.UserRepository.IsValidLogin(login, password);

            if (isValidLogin)
            {
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.IsSuccess = true;

                return response;
            }

            response.StatusCode = System.Net.HttpStatusCode.NotFound;

            return response;
        }

        public BaseResponse<object> RecoverLogin(string login)
        {
            var response = new BaseResponse<object>();

            var user = this.UserRepository.GetLogin(login);

            this.SendMail(user);

            return response;
        }

        private void SendMail(User user)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Jaca", "ajuda@jaca.com"));
            message.To.Add(new MailboxAddress($"Sr(a). {user.Login}", user.Email));
            message.Subject = "Recuperação de Senha'?";

            message.Body = new TextPart("plain")
            {
                Text = $@"Oi {user.Login},

Usuario: {user.Login}
Senha: {user.Password}
"
            };

            try
            {
                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("smtp.gmail.com", 587, false);

                    // Note: since we don't have an OAuth2 token, disable
                    // the XOAUTH2 authentication mechanism.
                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("arrozdajaca", "arrozdajaca#01");

                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
