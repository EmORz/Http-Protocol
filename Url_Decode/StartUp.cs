using System;
using System.IO;
using System.Net;
using System.Web;

namespace Url_Decode
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var encodingUrl = "http://url-decoder.com/i%23de%25?id=23";
            

            var resultDecode = HttpUtility.UrlDecode(encodingUrl);
            
            Console.WriteLine(resultDecode);


            /*You have been tasked to write a simple Console URL Decoder. You will receive an encoded URL. Your job is to decode the URL and print its decoded version on the console.
              Examples
              Input	Output
              http://www.google.bg/search?q=C%23	http://www.google.bg/search?q=C#
              https://mysite.com/show?n%40m3= p3%24h0	https://mysite/show?n@m3= p3$h0
              http://url-decoder.com/i%23de%25?id=23	http://url-decoder.com/i#de%?id=23
              Hints
              Use one of the methods of the WebUtility class.
              */
        }
    }
}
