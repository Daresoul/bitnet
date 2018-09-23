using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitnet
{
    class NetHandler
    {

        /// <summary>
        /// Checks if the url has a http or https connection
        /// </summary>
        /// <param name="url">This is the url you wanna check</param>
        /// <returns>returns if the url is valid</returns>
        public bool CheckUrl(string url)
        {
            if (url.Contains("http://") || url.Contains("https://"))
            {
                return true;
            }

            return false;
        }
    }
}
