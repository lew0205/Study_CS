﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;        // 0000 0000  0000 0000  0000 0000  0000 1111
            int b = 22;        // 0000 0000  0000 0000  0000 0000  0001 0110
            int c = a & b;     // 0000 0000  0000 0000  0000 0000  0000 0110 => 6
            Console.WriteLine("a & b: " + c);

                               // 0000 0000  0000 0000  0000 0000  0000 1111
                               // 0000 0000  0000 0000  0000 0000  0001 0110
            int d = a | b;     // 0000 0000  0000 0000  0000 0000  0001 1111 => 31
            Console.WriteLine("a | b: " + d);

                               // 0000 0000  0000 0000  0000 0000  0000 1111
                               // 0000 0000  0000 0000  0000 0000  0001 0110
            int e = a ^ b;     // 0000 0000  0000 0000  0000 0000  0001 1001 => 25 
            Console.WriteLine("a ^ b: " + e);

                               // 0000 0000  0000 0000  0000 0000  0000 1111
            int f = a << 2;    // 0000 0000  0000 0000  0000 0000  0011 1100 => 60
            Console.WriteLine("a << 2: " + f);
            Console.WriteLine("a << 1: " + (a << 1));

                               // 0000 0000  0000 0000  0000 0000  0001 0100
            int g = 20 >> 2;   // 0000 0000  0000 0000  0000 0000  0000 0101 => 5
            Console.WriteLine("20 >> 2: " + g);
            Console.WriteLine("(20 >> 2): " + (20 >> 1));

                               // 0000 0000  0000 0000  0000 0000  0001 0110
            int h = -b;        // 1111 1111  1111 1111  1111 1111  1110 1001 => -23
            Console.WriteLine("h = -b: " + h);

                               // 0000 0000  0000 0000  0000 0000  0001 0110
                               // 1111 1111  1111 1111  1111 1111  1110 1001 => -23
            int i = (-b) >> 2; // 1111 1111  1111 1111  1111 1111  1111 1010 => -6
            Console.WriteLine("i = (-b) >> 2: " + i);
        }
    }
}