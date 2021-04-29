using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class Program
    {
        public static void UC2()
        {
            int x1, x2, y1, y2;

            Console.WriteLine("Enter co-ordinates of First Line ");
            Console.WriteLine("Enter the value of x1:");      //enter the input x1
            x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 

    class lineecomparision
    {
        public static void Comparision()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter the value of x1:");      //enter the input x1
            x1 = Convert.ToInt32(Console.ReadLine());     //Convert into Int with the help of convert.ToInt32() 
            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");      //Enter the value y1
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula
            Console.WriteLine("Enter co-ordinates of Second Line ");
            Console.WriteLine("Enter the value of x1:");      //enter the input x1
            x1 = Convert.ToInt32(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");      //Enter the value y1
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            double Length2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

            bool status = Length1.Equals(Length2);  //compare both double values using Equals(Double) method

            if (status)
            {
                Console.WriteLine("Length of Line1 = Length of Line2 ");
            }

            else
            {
                Console.WriteLine("Length of Line1  is not equal to Length of Line2");

            }
            Console.WriteLine("The Length of Line1 is  " + Length1);  //finaly print output
            Console.WriteLine("The Length of Line2 is  " + Length2);  //finaly print output
            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

            Console.WriteLine("the length of a line is  " + Length);  //finally print output
            Console.Read();
        }
    }
}
