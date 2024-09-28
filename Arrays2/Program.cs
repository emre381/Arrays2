using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
     class Program  
    {
        static void Main(string[] args)
        {
            int[][] numbers = { new int[] { 2, 3 }, new int[] { 4 } };
            Console.WriteLine(numbers[1][0]);

            int[][,] numbers2 = new int[3][,] { new int[,] { { 2, 3 }, { 3, 4 } },
            new int[,]{ {4 },{5 } }, new int[,]{ { 1,2,3},{4,5,6 } }};
            Console.WriteLine(numbers2[2][0,2]);
            Console.ReadLine();

        }
    }
}
