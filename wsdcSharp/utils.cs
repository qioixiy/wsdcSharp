﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsdcSharp
{
    class utils
    {
        public static void ConsoleWriteHex(List<Byte> bs)
        {
            foreach (Byte b in bs)
            {
                Console.Write("0x{0:x2} ", b);
            }
        }
        public static void ConsoleWriteHex(Byte[] bs, int size)
        {
            int index = 0;
            foreach (Byte b in bs)
            {
                index++;
                if (index > size)
                {
                    break;
                }
                Console.Write("0x{0:x2} ", b);
            }
        }
        public static void ConsoleWriteHex(Byte[] bs)
        {
            foreach (Byte b in bs)
            {
                Console.Write("0x{0:x2} ", b);
            }
        }
    }
}
