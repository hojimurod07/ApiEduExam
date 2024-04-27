namespace Aplication.Interfases
{
    public  interface IEmailService
    {
        Task SendMessageAsync(string to, string subject, string message);
    }
}
