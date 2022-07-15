using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class Program
    {
        public class SubscriptionStatus
        {
            public bool Status { get; set; }

            public DateTime ExpireDate { get; set; }
        }

        public static void Main()
        {
            var x = new SubscriptionStatus();
            x = null;
            var result = x?.Status == true ? true : false;
            Console.WriteLine(result);
            
        }
    }
}