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
                var inputUrl = Console.ReadLine().ToLower();
                var inputtDecode = HttpUtility.UrlDecode(inputUrl);
                //
                var strArr = inputtDecode.Split("://");
                var protocol =strArr[0];
                var host = strArr[1].Split(".");
                var host1 = host[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
                var allHost = (host[0]+"." + host1[0]).Trim().Split(":")[0];
                var port =host1[0].Split(":") ;
                var portResult = "";
                if (port.Length>1)
                {
                    portResult = port[1];
                }
                else
                {
                    portResult = "80";
                }

                Console.WriteLine(portResult);
                var checker = (protocol == "http" || protocol=="https");

                Console.WriteLine(protocol);
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
