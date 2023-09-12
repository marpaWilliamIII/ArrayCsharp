using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ARRAY_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matrix Transpositon

            ////multidimensional array
            ////        Exercise: Matrix Transposition

            ////You are given a square matrix(an N x N 2D array) representing an image.Rotate the image by 90 degrees(clockwise).

            ////Write a function called rotate_matrix that takes an N x N matrix as input and modifies it in-place such that it is rotated 90 degrees clockwise.
            //int row ; int col; int loop;



            //Console.WriteLine("Enter Matrix size: ");
            //row = int.Parse(Console.ReadLine());
            //Console.WriteLine("X");
            //col = int.Parse(Console.ReadLine());


            //int[,] content = new int[row, col];

            ////Added this feature which will allow the user to input the values of the matrix 
            //for(int i = 0; i < row; i++)
            //{


            //    for(int j = 0; j < col; j++)

            //    { Console.Write("enter value for index ["+i+","+j+"]: ");
            //        content[i, j] = int.Parse(Console.ReadLine());


            //        loop = j;
            //        if(loop == col)
            //        {
            //            Console.WriteLine(" ");
            //        }

            //    }





            //}

            //Console.WriteLine("Matrix: ");

            //for (int r = 0; r < row; r++)
            //{


            //    for (int c = 0; c < col; c++)
            //    {
            //        Console.Write(content[r, c] + "\t");

            //        loop = c;
            //        if (loop == col-1)
            //        {
            //            Console.WriteLine("");
            //        }


            //    }


            //}

            //Console.WriteLine("Transpose:");



            //rotate_matrix();






            //Console.WriteLine("\n\n");





            //void rotate_matrix()
            //{



            //    for (int c = 0; c < col; c++)
            //    {
            //        for (int r = row-1; r >= 0; r--)
            //        {


            //            Console.Write(content[r, c] + "\t");

            //           loop = r;
            //            if (loop == 0)
            //            {
            //                Console.WriteLine("");
            //            }


            //        }





            //    }



            //}

            #endregion


            //Exercise: Find the Second Largest Element

            //        Write a function in your preferred programming language
            //        that takes an array of integers as input and returns the 
            //        second largest element from the array.If there is no second largest
            //        element, return a message indicating that.


            Console.WriteLine("start Here");

            int i = 0;
            int size;
            do {
                Console.Write("Enter numbers of elements to be evaluated : ");
                if(!int.TryParse(Console.ReadLine(), out size) )
                {
                    i++;
                    Console.WriteLine("Invalid input");

                }
                else
                {
                    i = 0;
                }
            }while(i > 0);  







          int[] num = new int[size];
          for(int k  = 0; k < size; k++)
            {
                do
                {
                    Console.Write($"Enter value for number {k+1}: ");
                    if (!int.TryParse(Console.ReadLine(), out num[k]))
                    {
                        i++;
                        Console.WriteLine("Invalid input");
                    }
                    else
                    {
                        i = 0;
                    }
                } while (i > 0);
                
                
            }

            Console.WriteLine("\n");


         int max = num.Max();
           
            Console.WriteLine("get");























        Console.ReadKey();
        }
    }
}
