using System;
using System.Collections.Generic;
using System.Linq;


// Singleton MultiThreading using Double Checked Locking 
namespace SingletonMultiThreading
{
    public class LoadBalancer
    {
        private static LoadBalancer? instance;
        List<string> servers = new();
        Random random = new();

        private static object locker = new();

        private LoadBalancer()
        {
            servers.Add("Server 01");
            servers.Add("Server 02");
            servers.Add("Server 03");
            servers.Add("Server 04");
        }

        public static LoadBalancer GetLoadBalancer()//--Double Checked Locking
        {
            if (instance == null)
            {
                lock(locker)
                {
                    if (instance ==null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }
        
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

                if (b1 == b2 && b2 == b3 && b3 ==b4)
                {
                    Console.WriteLine("Same instance");
                }

                //Load balance 12 server requests in random
                LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
                for( int i =0; i <=12; i++)
                {
                    string server = balancer.Server;
                    Console.WriteLine("Dispatch request to : " + server);
                }

            }
        }

    }
}