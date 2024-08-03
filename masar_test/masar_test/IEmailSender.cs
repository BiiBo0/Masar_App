using System;
namespace SendingEmails
{
  public interface IEmailSender
  {
        Task SendEnailAsynsc(string email, string subject, string message);

  }

}


