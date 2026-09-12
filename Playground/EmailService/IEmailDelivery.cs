
namespace Playground.EmailService;

public interface IEmailDelivery
{
    Task SendAsync(EmailMessage message, CancellationToken cancellationToken = default);
}
