﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Calculate
    {
        public static int Add(int a, int b)
        {
            a += b; return a;
        }

        public static int Subtract(int a, int b)
        {
            a -= b; return a;
        }

        public static int Multiply(int a, int b)
        {
            a*= b; return a;
        }

        public static int Divide(int a, int b)
        {
            a /= b; return a;
        }
    }
}
