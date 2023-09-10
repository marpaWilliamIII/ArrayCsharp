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
                   
                    Console.Write("\r\t");
                }





            }
         

            void Matrix()
            {

                



            }
















            Console.ReadKey();
        }
    }
}
