using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerateReverseArray 
            //var arr = GenerateReverseArray.ReverseSeq(5);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //Multiplication Table
            //var arr = MultiplicationTable.GenerateTable(3);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            var arr = new int[] { 10, 10, 8, 15, 7, 6, 4, 12, 12 };

            Console.WriteLine(HighestRankNumberInArray.HighestRank(arr));

            Console.ReadLine();
        }
    }
}
