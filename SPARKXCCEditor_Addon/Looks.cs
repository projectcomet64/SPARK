using M64MM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTSpark
{
    public static class Looks
    {
        public static List<int> shadowAddresses = new List<int>();

        public static void FromColorCode(string code, ref BindingList<ColorPart> cParts, byte shadeX, byte shadeY, byte shadeZ)
        {
            byte[] buffer = new byte[0x90];
            foreach(string line in code.Split('\n'))
            {
                string[] gsParts;
                byte[] cData;
                gsParts = line.Split(' ');
                cData = Core.StringToByteArray(gsParts[1]);
                long addr = (long.Parse(gsParts[0], System.Globalization.NumberStyles.HexNumber) & 0x00FFFFFF) - 0x7EC20;
                // This means this is a SCC
                if (addr >= 0x1E0)
                {
                    continue;
                }
                if (addr >= 0x90 && buffer.Length == 0x90)
                {
                    byte[] neoBuffer = new byte[0x1E0];
                    buffer.CopyTo(neoBuffer, 0);
                    buffer = neoBuffer;
                }
                cData.CopyTo(buffer, addr);
            }

            foreach(ColorPart cPart in cParts)
            {
                if (cPart.offset_86 > buffer.Length)
                {
                    continue;
                }
                cPart.light = Color.FromArgb(buffer[cPart.offset_86],
                    buffer[cPart.offset_86+1],
                    buffer[cPart.offset_86+2]);
                cPart.dark = Color.FromArgb(buffer[cPart.offset_88],
                    buffer[cPart.offset_88 + 1],
                    buffer[cPart.offset_88 + 2]);
            }
        }

        public static BindingList<ColorPart> xccDefaults = new BindingList<ColorPart>
        {
            new ColorPart
            {
                name = "Hat",
                offset_88 = 0x18,
                offset_86 = 0x20,
                default_light = Color.FromArgb(255, 0, 0),
                default_dark = Color.FromArgb(128, 0, 0)
            },
            new ColorPart
            {
                name = "Hair",
                offset_88 = 0x78,
                offset_86 = 0x80,
                default_light = Color.FromArgb(115, 6, 0),
                default_dark = Color.FromArgb(57, 3, 0)
            },
            new ColorPart
            {
                name = "Skin",
                offset_88 = 0x60,
                offset_86 = 0x68,
                default_light = Color.FromArgb(254, 193, 121),
                default_dark = Color.FromArgb(127, 96, 60)
            },
            new ColorPart
            {
                name = "Shirt",
                offset_88 = 0x90,
                offset_86 = 0x98,
                default_light = Color.FromArgb(255, 0, 0),
                default_dark = Color.FromArgb(128, 0, 0)
            },
            new ColorPart
            {
                name = "Shoulders",
                offset_88 = 0xA8,
                offset_86 = 0xB0,
                default_light = Color.FromArgb(255, 0, 0),
                default_dark = Color.FromArgb(128, 0, 0)
            },
            new ColorPart
            {
                name = "Arms",
                offset_88 = 0xC0,
                offset_86 = 0xC8,
                default_light = Color.FromArgb(255, 0, 0),
                default_dark = Color.FromArgb(128, 0, 0)
            },
            new ColorPart
            {
                name = "Gloves",
                offset_88 = 0x30,
                offset_86 = 0x38,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Overalls Top",
                offset_88 = 0x0,
                offset_86 = 0x8,
                default_light = Color.FromArgb(0, 0, 255),
                default_dark = Color.FromArgb(0, 0, 128)
            },
            new ColorPart
            {
                name = "Overalls Bottom",
                offset_88 = 0xD8,
                offset_86 = 0xE0,
                default_light = Color.FromArgb(0, 0, 255),
                default_dark = Color.FromArgb(0, 0, 128)
            },
            new ColorPart
            {
                name = "Leg Top",
                offset_88 = 0xF0,
                offset_86 = 0xF8,
                default_light = Color.FromArgb(0, 0, 255),
                default_dark = Color.FromArgb(0, 0, 128)
            },
            new ColorPart
            {
                name = "Leg Bottom",
                offset_88 = 0x108,
                offset_86 = 0x110,
                default_light = Color.FromArgb(0, 0, 255),
                default_dark = Color.FromArgb(0, 0, 128)
            },
            new ColorPart
            {
                name = "Shoes",
                offset_88 = 0x48,
                offset_86 = 0x50,
                default_light = Color.FromArgb(115, 6, 0),
                default_dark = Color.FromArgb(57, 3, 0)
            },
            new ColorPart
            {
                name = "Custom 1",
                offset_88 = 0x120,
                offset_86 = 0x128,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 2",
                offset_88 = 0x138,
                offset_86 = 0x140,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 3",
                offset_88 = 0x150,
                offset_86 = 0x158,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 4",
                offset_88 = 0x168,
                offset_86 = 0x170,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 5",
                offset_88 = 0x180,
                offset_86 = 0x188,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 6",
                offset_88 = 0x198,
                offset_86 = 0x1A0,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 7",
                offset_88 = 0x1B0,
                offset_86 = 0x1B8,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            },
            new ColorPart
            {
                name = "Custom 8",
                offset_88 = 0x1C8,
                offset_86 = 0x1D0,
                default_light = Color.FromArgb(255, 255, 255),
                default_dark = Color.FromArgb(128, 128, 128)
            }
        };
    }
}
