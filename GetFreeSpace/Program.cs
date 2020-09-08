using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFreeSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceChecker CheckNow = new SpaceChecker();
            CheckNow.Location = args[0];
            try
            {
                string x = CheckNow.Get();
                Console.WriteLine(x.ToString());
            }
            catch (Exception r) { Console.WriteLine("Error getting free space: " + r.Message); }
            
        }
    }
}
