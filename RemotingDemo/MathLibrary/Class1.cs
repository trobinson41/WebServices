﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathService : MarshalByRefObject
    {
        int Count;

        public MathService()
        {
            Console.WriteLine("MathService is Instantiated");
        }

        public int Add(int a, int b)
        {
            Count++;
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Count++;
            return a - b;
        }

        public int GetCounter()
        {
            return Count;
        }
    }
}
