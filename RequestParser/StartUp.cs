using System;
using System.Collections.Generic;
using System.Text;

namespace RequestParser
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<DataKeeper> data = new List<DataKeeper>();
            while (true)
            {
                var validPaths = Console.ReadLine().ToLower();
                if (validPaths == "end")
                {
                    break;
                }

                var parts = validPaths.Split("/", StringSplitOptions.RemoveEmptyEntries);
                var path = parts[0];
                var method = parts[1];

                DataKeeper keeper = new DataKeeper();
                keeper.Path = path;
                keeper.Method = method;
                data.Add(keeper);

            }
            var httpRequest = Console.ReadLine().ToLower();
            var httpTokens = httpRequest.Split(" ");
            var httpMethod = httpTokens[0];
            var httpStatusCode = httpTokens[2];
            var httpPath = httpTokens[1].Split("/", StringSplitOptions.RemoveEmptyEntries)[0];

            var validate = data;
            StringBuilder sb = new StringBuilder();


            var check = true;
            foreach (var validData in validate)
            {
                if (validData.Path == httpPath && validData.Method == httpMethod)
                {
                    sb.AppendLine("HTTP/1.1 200 OK");
                    var contentLenght = "OK".Length;
                    sb.AppendLine($"Content-Length: {contentLenght}");
                    sb.AppendLine($"Content-Length: text/plain");
                    sb.AppendLine(Environment.NewLine);
                   
                    sb.AppendLine("OK");
                    check = false;
                }
            }

            if (check)
            {
                sb.AppendLine("HTTP/1.1 404 NotFound");
                var contentLenght = "NotFound".Length;
                sb.AppendLine($"Content-Length: {contentLenght}");
                sb.AppendLine("Content-Type: text/plain");
                sb.AppendLine(Environment.NewLine);
                sb.AppendLine("NotFound");
            }
            var result = sb.ToString().Trim();
            Console.WriteLine(result);





        }
    }
}
