using System;
using api.Services.interfaces;
using Microsoft.Extensions.Configuration;

namespace api.Services
{
  public class LocalMailService : IMailService
  {
    private IConfiguration _config;

    public LocalMailService(IConfiguration config)
    {
      _config = config ?? throw new ArgumentNullException(nameof(config));
    }

    public void Send(string subject, string message)
    {
      Console.WriteLine($"Sending email to {_config["MailSettings:MailToAddress"]} from {_config["MailSettings:MailToAddress"]} with subject {subject} and message {message}");
    }
  }
}