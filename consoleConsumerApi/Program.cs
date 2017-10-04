using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace consoleConsumerApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var docJson = client.DownloadString(@"http://localhost:1395/api/Funcionarios");

            List<dynamic> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(docJson.ToString());
            foreach(var i in list)
            {
                Console.WriteLine(i.Nome);
            }
            Console.ReadKey(true);
        }
    }
}
