using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetDiskFreeSpace
{
    class DiskSpaceHelper
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,out ulong lpFreeBytesAvailable,out ulong lpTotalNumberOfBytes,out ulong lpTotalNumberOfFreeBytes);



        public static (string directoryName,string totalSpace, string freeSpace, double freePrecent ) GetDiskSpaceInfo(string directoryName)
        {
            GetDiskFreeSpaceEx(directoryName, out ulong available, out ulong total, out ulong free);



            return (directoryName, $"{ConvertToMB(total)} MB ({total})", $"{ConvertToMB(available)} MB ({available})", ((double)available / total ) );
        }

        private static double ConvertToMB(ulong value)
        {
            return value / 1048576.0;
        }
    }
}
