using System;
using System.Configuration;

namespace Agnie
{
    public class Program
    {
       
        static async System.Threading.Tasks.Task Main(string[] args)
        {             
            Subscribers subscribers = new Subscribers();
            await subscribers.GetSubscriberlist();
            Console.ReadKey();
        }
    }
}
