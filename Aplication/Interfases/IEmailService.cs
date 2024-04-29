namespace Aplication.Interfases
{
    public interface IEmailService
    {
        Task SendMessageToEmailAsync(string to, string title, string body);
    }
}
