using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDiskFreeSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DiskSpaceHelper.GetDiskSpaceInfo(@"C:\");
            Console.WriteLine(result.directoryName);
            Console.WriteLine(result.totalSpace);
            Console.WriteLine(result.freeSpace);
            Console.WriteLine(result.freePrecent);


            Console.ReadLine();
        }
    }
}
