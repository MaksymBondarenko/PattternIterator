using ConsoleApp1.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialSpammer socialSpammer = new SocialSpammer(new Facebook());
            socialSpammer.Send();
        }
    }
}
