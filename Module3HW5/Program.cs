using System.IO;

internal class Program
{
    public static string firstPart => "TextFileHello.txt";
    public static string secondPart => "TextFileWorld.txt";


    async static Task Main(string[] args)
    {
        var task1 = ReadTextPart(firstPart);
        var task2 = ReadTextPart(secondPart);
         
       var texts= await Task.WhenAll(task1, task2);

        Console.WriteLine($"{string.Join(string.Empty, texts)}");

    }


    public static async Task<string> ReadTextPart(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string text = await reader.ReadToEndAsync();
            return text;
        }
    }
}
