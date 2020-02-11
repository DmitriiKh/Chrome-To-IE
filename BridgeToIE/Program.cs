using System;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BridgeToIE
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = String.Empty;

            using (var standardInput = Console.OpenStandardInput())
            {
                // 1024 byte should be enough for URL
                var buffer = new byte[1024];

                // the first 4 bytes contain the length 
                standardInput.Read(buffer, 0, 4);
                var length = BitConverter.ToInt32(buffer, 0);

                // the rest is URL
                standardInput.Read(buffer, 0, length);
                var jsonString = Encoding.UTF8.GetString(buffer);
                url = JObject.Parse(jsonString)["url"].ToString();
            }

            Process.Start("iexplore.exe", url);
        }
    }
}
