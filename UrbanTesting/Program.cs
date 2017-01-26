using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanDictionnet;
namespace UrbanTesting
{
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync(args).GetAwaiter().GetResult();
        private  async Task MainAsync(string[] args)
        {
            var c = new UrbanClient();
            var test = await c.GetWordAsync("test");
            Console.ReadKey();
        }
    }
}
