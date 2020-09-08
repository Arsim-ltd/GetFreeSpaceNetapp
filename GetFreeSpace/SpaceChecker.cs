using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GetFreeSpace
{
    class SpaceChecker
    {

        [DllImport("kernel32")]
        public static extern int GetDiskFreeSpaceEx(
        string lpDirectoryName,
        ref long lpFreeBytesAvailable,
        ref long lpTotalNumberOfBytes,
        ref long lpTotalNumberOfFreeBytes
        );

        public string Location { get; set; }

        public string Get()
        {
            long FreeBytesAvailable = 0;
            long TotalNumberOfBytes = 0;
            long TotalNumberOfFreeBytes = 0;

            int bRC = GetDiskFreeSpaceEx(Location, ref FreeBytesAvailable, ref TotalNumberOfBytes, ref TotalNumberOfFreeBytes);
            long FreeGB = FreeBytesAvailable / 1024 / 1024 / 1024;
            long TotalGB = TotalNumberOfBytes / 1024 / 1024 / 1024;
            float FreePercentage = ((float)FreeGB / (float)TotalGB) * 100;
            return FreePercentage.ToString("0.00");
        }
    }
}
