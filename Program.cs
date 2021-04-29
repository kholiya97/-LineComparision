using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Choice Anyone Program **\n1.Calculate The Length Of Line\n2.Calculate The Length Of two Line\n3.Calculate The Length and check one line is equal, greater or less then the other line ");
            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    lineecomparision.Comparision();
                    break;
                case 2:
                    LengthOfTwoLine.UC2();
                    break;
                case 3:
                    LineGreaterOrLess.UC3();
                    break;
            }
            //lineecomparision.Comparision();
            //LengthOfTwoLine.UC2();
            // LineGreaterOrLess.UC3();
        }
    }
}
