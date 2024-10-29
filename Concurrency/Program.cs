using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string data = await FetchDataAsync();
        Console.WriteLine(data);
    }

    static async Task<string> FetchDataAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            return await client.GetStringAsync("https://api.github.com");
        }
    }
}
