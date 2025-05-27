namespace GuestHouseBackEnd.Services
{
    public class EmailServicecs
    {
        public Task SendEmailAsync(string to, string subject, string body)
        {
            // Simulate sending email
            Console.WriteLine($"Email to: {to}, Subject: {subject}\nBody: {body}");
            return Task.CompletedTask;
        }
    }
}
