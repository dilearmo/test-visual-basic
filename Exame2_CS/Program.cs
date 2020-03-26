using Exame2_CS.POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            //POO_4.Exec();
            var input = new List<List<int>>
            {
                new List<int>(new int[1] { 3}),
                new List<int>(new int[3] { 11, 2, 4}),
                new List<int>(new int[3] { 4,5,6}),
                new List<int>(new int[3] { 10, 8, -12}),
            };

            var res = diagonalDifference(input);

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            var sumaDerecha = 0;
            var sumaIzquierda = 0;

            for (var i = 1; i < arr.Count; i++)
            {
                for (var j = 0; j < arr[i].Count; j++)
                {
                    if (i - 1 == j)
                    {
                        sumaDerecha += arr[i][j];
                    }

                    if ((arr[i].Count - 1) - (i - 1) == j)
                    {
                        sumaIzquierda += arr[i][j];
                    }
                }
            }

            return Math.Abs(sumaDerecha - sumaIzquierda);
        }
    }
}
