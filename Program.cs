using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            int width = 5;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle (Botton left)");
                Console.WriteLine("2. Draw the triangle (Botton right)");
                Console.WriteLine("3. Draw the triangle (Top left)");
                Console.WriteLine("4. Draw the triangle (Top right)");
                Console.WriteLine("5. Draw the isosceles triangle");
                Console.WriteLine("6. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle (Botton left)");
                        DrawTriangleBottonLeft(width);
                        break;
                    case 2:
                        Console.WriteLine("Draw the triangle (Botton right)");
                        DrawTriangleBottonRight(width);
                        break;
                    case 3:
                        Console.WriteLine("Draw the triangle (Top left)");
                        DrawTriangleTopLeft(width);
                        break;
                    case 4:
                        Console.WriteLine("Draw the triangle (Top right)");
                        DrawTriangleTopRight(width);
                        break;
                    case 5:
                        Console.WriteLine("Draw the isosceles triangle");
                        DrawIsoscelesTriangle(width);
                        break;
                    case 6:
                        Console.WriteLine("Draw the rectangle");
                        DrawRectangle(width, 10);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }

        }
        private static void DrawTriangleBottonLeft(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void DrawTriangleBottonRight(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= width - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        private static void DrawTriangleTopLeft(int width)
        {
            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void DrawTriangleTopRight(int width)
        {
            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j <= width - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        private static void DrawIsoscelesTriangle(int width)
        {
            for (int i = 1; i <= limit; i++)
                {
                    for (int j = 1; j <= limit - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
        }
        private static void DrawRectangle(int width, int height)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
