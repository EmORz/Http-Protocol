using System;
using System.Linq;
using System.Web;

namespace ValidateUrl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var inputUrl = Console.ReadLine();
                var inputtDecode = HttpUtility.UrlDecode(inputUrl);
                //
                var strArr = inputtDecode.Split("://");
                var protocol =strArr[0];
                var host = strArr[1].Split(".");
                var host1 = host[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
                var allHost = (host[0]+"." + host1[0]).Trim().Split(":")[0];
                //
                var port = host1[0].Split(":");
                var portResult = "";
                var checkerProtocol = (protocol == "http" || protocol == "https");
                var checkerHost = allHost.Length >= 4;

                if (checkerHost&&checkerProtocol)
                {
                    if (port.Length > 1)
                    {
                        portResult = port[1];
                    }
                    else
                    {
                        portResult = "80";
                    }

                    var path = "";
                    if (host1.Length == 1)
                    {
                        path = "/";
                    }
                    else
                    {
                        path = host1[1].Split("?")[0];
                    }
                    Console.WriteLine($"Protocol: {protocol}");
                    Console.WriteLine($"Host: {allHost}");
                    Console.WriteLine($"Port: {portResult}");
                    Console.WriteLine($"Path: {path}");
                }
                //
                if (host1.Length==2)
                {
                    var query = host1[1].Split("?")[1].Split("#");
                    Console.WriteLine($"Query: {query[0]}");
                    Console.WriteLine($"Fragment: {query[1]}");
                }
        





            }
     
        }

        /*"Protocol: {protocol}"
           "Host: {host}"
           "Port: {port}"
           "Path: {path}"
           "Query: {query string}" (if any)
           "Fragment: {fragment}" (if any)
           */
    }
}
