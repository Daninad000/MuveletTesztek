using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muveletek;
using NUnit.Framework;

namespace MuveletTesztek
{
    [TestFixture]
    public class MuveletTesztek
    {
        static void Main(string[] args)
        {
            Osszeadas a = new Osszeadas("", "222");
            Console.WriteLine(a.osszeadMaskepp());
            Kivonas k = new Kivonas("", "");
            Console.WriteLine(k.kivon());
            Console.ReadKey();


        }
    }
}
