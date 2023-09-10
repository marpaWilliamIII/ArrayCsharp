using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ARRAY_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //multidimensional array
            //        Exercise: Matrix Transposition

            //You are given a square matrix(an N x N 2D array) representing an image.Rotate the image by 90 degrees(clockwise).

            //Write a function called rotate_matrix that takes an N x N matrix as input and modifies it in-place such that it is rotated 90 degrees clockwise.
            int row = 3; int col = 3;   

            int[,] content = new int[row, col];


            for(int i = 0; i < row; i++)
            {


                for(int j = 0; j < col; j++)

                { Console.Write("enter value for index ["+i+","+j+"]: ");
                    content[i, j] = int.Parse(Console.ReadLine());
                   
               
                }





            }
            int loop;

            for (int r = 0; r < row; r++)
            {


                for (int c = 0; c < col; c++)
                {
                    Console.Write(content[r, c] + "\t");

                    loop = c;
                    if (loop == 2)
                    {
                        Console.WriteLine("");
                    }


                }


            }

            Console.WriteLine("");
           









            for (int c = 0; c < col; c++)
            {
                for (int r = 2; r >= 0; r --)
                {


                  Console.Write(content[r, c] + "\t");

                  loop = c;
                  if (loop == 2)
                  {
                    Console.WriteLine("");
                       
                  }

               
                }




            }


            Console.WriteLine("\n\n");


               


            void Matrix()
            {

                



            }
















            Console.ReadKey();
        }
    }
}
