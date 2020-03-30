using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxs = new boxs();
            Console.WriteLine(boxs.IsNullOrEmpty());
        }
    }

    public class boxs : List<int>
    {
    }
}
