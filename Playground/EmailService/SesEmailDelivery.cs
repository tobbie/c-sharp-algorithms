


using Amazon;
using Amazon.Runtime;
using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

namespace Playground.EmailService;

public sealed class SesEmailDelivery : IEmailDelivery
{
    private readonly IAmazonSimpleEmailServiceV2 _ses;
    private readonly string _fromAddress;
    private readonly string AccessKey = "";
    private readonly string SecretKey = "";
    public SesEmailDelivery()
    {
            var credentials =  new BasicAWSCredentials(AccessKey, SecretKey);
            _ses = new AmazonSimpleEmailServiceV2Client(credentials, RegionEndpoint.EUWest1);
           _fromAddress = "";
    }
    public async Task SendAsync(EmailMessage message, CancellationToken cancellationToken = default)
    {
        var request = new SendEmailRequest
        {
            FromEmailAddress = _fromAddress,
            Destination = new Destination { ToAddresses = message.To.ToList() },
            Content = new EmailContent
            {
                Simple = new Message
                {
                    Subject = new Content
                    {
                        Data = message.Subject,
                    },

                    Body = message.IsHtml ? new Body   {  Html = new Content {  Data = message.Body}  } // use html body
                                          : new Body   {  Text = new Content {  Data = message.Body } }// otehrwise use text body
                }
            }

        };

        await _ses.SendEmailAsync(request, cancellationToken);
    }
}
