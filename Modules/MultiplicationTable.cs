using System;
using System.Collections.Generic;
using System.Linq;
namespace Modules
{
    public class MultiplicationTable
    {
        public static int[,] GenerateTable(int size)
        {
            var arr = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //if(i==0)
                    //{
                    //    arr[i, j] = j + 1;
                    //}
                    //else
                    //{
                    //    arr[i, j] = (j + 1)*(i+1);
                    //}

                    //i == 0 ? (arr[i, j] = j + 1) : arr[i, j] = (j + 1) * (i + 1);
                    arr[i, j] = i == 0 ? (j + 1) : ((j + 1) * (i + 1));
                }
            }
            return arr;
        }
    }
}
