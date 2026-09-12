using Playground.BytesExamples;
using Playground.EmailService;
using System.Threading.Tasks;
using static System.Console;

namespace ProgramEntryPoint;

public class Program
{
    //public static void Main(string[] args)
    //{
    //    ConvertTextToBytes.Run();
    //}
    public static async Task Main(string[] args)
    {
        var emailDelivery = new SesEmailDelivery();
        var email = new EmailMessage
        {
            To = new[] { "", "" },
            Subject = "SES Test Email 1",
            Body = """
                        <h1> Hello from Amazon SES! Part 1 </h1>
                        <p> This is a test email from Tobi's C# application.</p>
                        <p>You're doing well 1</P>
                   """,
            IsHtml = true
        };

     

        WriteLine("Preparing to send email......");

        await Task.Delay(2000);

        await emailDelivery.SendAsync(email);
   
    }
}
