
namespace Playground.EmailService;

public sealed class EmailMessage
{
    public required IReadOnlyCollection<string> To { get; init;  }
    public required string Subject { get; init; }
    public required string Body { get; init; }
    public bool IsHtml  { get; init; }
}
