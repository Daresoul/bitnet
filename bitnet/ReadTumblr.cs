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

        /// <summary>
        /// Will get data of a webpage
        /// </summary>
        /// <param name="uri">this is the url for the code to get the data of</param>
        /// <returns>Returns string of html from site</returns>
        public string ReadContent(string uri)
        {
            // Will create a web client
            System.Net.WebClient wc = new System.Net.WebClient();

            // Will download the data of the URL
            byte[] raw = wc.DownloadData(uri);

            // Will create a UTF8 version of the string
            string webData = System.Text.Encoding.UTF8.GetString(raw);

            // Returns value
            return webData;
        }

        /// <summary>
        /// This will search for a pattern in a given html code!
        /// </summary>
        /// <param name="html">This is the raw HTML code</param>
        /// <returns>Returns array of strings with the content of the matches</returns>
        public string[] SearchForPost(string html)
        {
            // Removes all newline types
            var myString = html.Replace("\n", "");
            myString = myString.Replace("\r", "");
            myString = myString.Replace(Environment.NewLine, "");

            // Regex pattern - Will look for div with class body-text and get content until end div
            string pattern = "<div class=\"body-text\">(.*?)<\\/div>";

            // test the new HTML string with the regex pattern
            MatchCollection matches = Regex.Matches(myString, pattern);

            // Converts results to array of strings
            var MatchesArray = matches.Cast<Match>().Select(m => m.Value).ToArray();

            // Returns array of matches
            return MatchesArray;
        }
    }
}
