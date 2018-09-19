using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLibrary
{
    public interface IMathService
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int GetCount();
    }
    public class MathService : MarshalByRefObject, IMathService
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
        public int GetCount()
        {
            return Count;
        }
    }
}
