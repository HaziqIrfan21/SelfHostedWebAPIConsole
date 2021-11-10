using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;

namespace SelfHostedWebAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost1234");
            var server = new HttpSelfHostServer(config, new WebApiMessageHandler());
            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Self Host CMD application started");
            Console.ReadLine();
        }

        //public void Input()
        //{
        //    Console.WriteLine("Please select your choice");
        //    Console.WriteLine("1. Upper case, lower case and camelcasing");
        //    Console.WriteLine("2. Take a string as input and return a list of string based on the input spliting character");
        //    Console.WriteLine("3. Take a string as input and reverse it");
        //   int res =  int.Parse(Console.ReadLine());

        //    switch (res)
        //    {
        //        case 1:

        //            Casing();
        //            break;

        //        case 2:
                   

        //            break;

        //        case 3:
                 

        //            break;

        //        default:
        //            break;
        //    }

        //}

        //public void Casing()
        //{
        //    Console.WriteLine("Input string");
        //   string input = Console.ReadLine();
        //    Console.WriteLine(input.ToUpper());
        //    Console.WriteLine(input.ToLower());
        



        //}

        //public void Split()
        //{
        //    Console.WriteLine("Input string");
        //}

        //public void Reverse()
        //{
        //    Console.WriteLine("Input string");
        //}

    }
}
