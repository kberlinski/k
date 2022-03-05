using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var httpclient = new HttpClient();
            var resp = await httpclient.GetAsync("https://pja.edu.pl");
            Console.WriteLine("Hello World!");
        }
    }
}
