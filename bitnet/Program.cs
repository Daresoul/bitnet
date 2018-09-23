using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var read = new ReadTumblr();
            var consoleHandler = new ConsoleHandler();
            //consoleHandler.ToggleWindow();

            // Will get the content of the site
            var content = read.ReadContent("https://fest.dk/bitnet.html");
 
            // Will get an array of results
            var results = read.SearchForPost(content);

            // Will write out the first result
            Console.WriteLine(results[0]);

            Console.ReadLine();
        }
    }
}
