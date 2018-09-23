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
            Console.WriteLine("Getting Html");
            //var content = "<div class=\"body-text\">\n<p>yasss</p>\n</div>";
            var content = read.ReadContent();
            Console.WriteLine(content);
            Console.WriteLine("\nGetting divs");
            read.SearchForPost(content);
            Console.ReadLine();
        }
    }
}
