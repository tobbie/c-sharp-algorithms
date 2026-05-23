using System.Text;
using static System.Console;


namespace Playground.BytesExamples;
public class ConvertTextToBytes
{
    public static void Run()
    {
        // StringToBytes();
        //IntToBytes();

        // TextToFiles();
        ReadFileToBytes();
        // LongToByte();


    }

    public static void StringToBytes()
    {
        WriteLine("convert string to bytes");
        string text = "Oluwatobi Akinseye";

        byte[] bytes = Encoding.UTF8.GetBytes(text);

        WriteLine(bytes.Length);

        foreach (byte item in bytes)
        {
            Write($"{item} ");
        }

        WriteLine("convert bytest  to binary");
        foreach (byte item in bytes)
        {
            WriteLine(Convert.ToString(item, 2).PadLeft(8, '0'));
        }

        ReadLine();
        WriteLine("converting back to string");
        //convert back to text

        bytes[0] = 74;
        bytes[1] = 99;
        string convertedBack = Encoding.UTF8.GetString(bytes);
        WriteLine(convertedBack);

        ReadLine();
    }
    public static void IntToBytes()
    {
        WriteLine("convert integer to bytes");
        int number = 42;
        byte[] intBytes = BitConverter.GetBytes(number);

        PrintBytesToConsole(intBytes);

        ReadLine();
    }

    public static void TextToFiles()
    {
        WriteLine("Write text to file with bytes");
        string input = "Hello I'm Oluwatobi Akinseye. and I'm married";

        byte[] data = Encoding.UTF8.GetBytes(input);
        PrintBytesToConsole(data);

        File.WriteAllBytes(@"C:\Log\test.txt", data);

        WriteLine(Directory.GetCurrentDirectory());

        WriteLine("Done");



        ReadLine();
    }

    public static void PrintBytesToConsole(byte[] bytes)
    {
        if (bytes == null || bytes.Length == 0)
            return;

        WriteLine($"length of bytes is: {bytes.Length}");
        WriteLine();
        foreach (byte item in bytes)
        {
            WriteLine($"byte is: {item}");
        }
        WriteLine();
    }

    public static void ReadFileToBytes()
    {
        //FRE_Log_20231221
        WriteLine("Readin file at ");
        string path = @"C:\Log\jd.pdf";
        var exists = File.Exists(path);

        WriteLine($"Readin file at {path}");
        var bytes = File.ReadAllBytes(path);

        //PrintBytesToConsole(bytes);

        Span<byte> mySpan = bytes.AsSpan(2, 10);
        WriteLine(mySpan.Length);

        PrintBytesToConsole(mySpan.ToArray());
        WriteLine("Done");
        ReadLine();

        //convert bytes to text

        // string output = Encoding.UTF8.GetString(bytes);
        // WriteLine(output);



    }

    public static void LongToByte()
    {
        long number = 2394920;
        byte[] longBytes = BitConverter.GetBytes(number);
        PrintBytesToConsole(longBytes);
    }
}
