using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IsNullOrEmpty
            var boxs = new boxs();
            Console.WriteLine(boxs.IsNullOrEmpty());
            #endregion

            #region  AddIfNotContains
            Console.WriteLine();
            Console.WriteLine(boxs.AddIfNotContains(1));
            #endregion

            #region AddIfNotContains 
            Console.WriteLine();
            var items = new List<int>() { 2, 3, 4 };
            var items1 = boxs.AddIfNotContains(items);
            foreach (var item in items1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region AddIfNotContains
            Console.WriteLine();
            var item1 = 5;
            boxs.AddIfNotContains(x => x == 5, () => item1);
            foreach (var item in boxs)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region RemoveAll
            Console.WriteLine();
            IList<int> items4 = boxs.RemoveAll<int>(x => x % 2 == 0);
            foreach (var item in items4)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }

    public class boxs : List<int>
    {
    }


}
