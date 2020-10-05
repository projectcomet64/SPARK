using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M64MM.Utils;

using static M64MM.Utils.Core;
namespace CMTSpark
{
    public static class Polyfills
    {
        public static long SegmentedToVirtual(uint address, bool useBase = true)
        {
            byte[] byteArray = BitConverter.GetBytes(address);
            if (byteArray.Length == 4)
            {
                uint segment = address >> 24;
                uint segmentedOffset = address & 0x00FFFFFF;
                if (segment <= 0x1F && segment >= 0)
                {
                    long segmentedBase = (BitConverter.ToUInt32(
                    ReadBytes(BaseAddress + 0x33B400 + segment * 4, 4), 0));
                    //MinValue of int just so happens to be 0x80000000 so it's perfect
                    return segmentedBase + segmentedOffset + (useBase ? BaseAddress : 0);
                }
                else
                {
                    throw new ArgumentException("Segments range from 00 to 1F.");
                }
            }
            else
            {
                throw new ArgumentException("Invalid address");
            }
        }
    }
}
