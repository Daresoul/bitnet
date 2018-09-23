using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bitnet
{
    class ReadTumblr
    {
        public string ReadContent()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://www.york.ac.uk/teaching/cws/wws/webpage1.html");
            string webData = System.Text.Encoding.UTF8.GetString(raw);
            return webData;
        }

        public void SearchForPost(string html)
        {
            var myString = html.Replace("\n", "");
            myString = myString.Replace("\r", "");
            myString = myString.Replace(Environment.NewLine, "");
            string pattern = "<div class=\"body-text\">(.*?)<\\/div>";
            MatchCollection matches = Regex.Matches(myString, pattern);
            Console.WriteLine("Matches found: {0}", matches.Count);

            if (matches.Count > 0)
                foreach (Match m in matches)
                    Console.WriteLine("{0}", m.Groups[1]);
        }

        public void WriteToConsole(IEnumerable items)
        {
            foreach (Match m in items)
                Console.WriteLine("Inner DIV: {0}", m.Groups[1]);
        }
    }
}
