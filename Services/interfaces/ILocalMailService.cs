namespace api.Services.interfaces
{
  public interface IMailService
  {
    void Send(string subject, string message);
  }
}