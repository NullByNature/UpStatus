using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrabWebsite;

namespace UpStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                // Hold off for 1 second so the message is not sent before returning website status 
                Thread.Sleep(1000);

                Console.WriteLine("Enter the full website link that you want to check");
                string link = Console.ReadLine();
                // make sure link is not blank 
                while (string.IsNullOrEmpty(link))
                {
                    Console.WriteLine("Link can not be blank\n");
                    link = Console.ReadLine();
                }
                WebsiteGrabber grabber = new WebsiteGrabber();
                grabber.GetWebsite(link);
            }
        }
    }
}