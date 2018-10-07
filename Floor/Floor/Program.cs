using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            RoomA();
            RoomB();
            RoomMaker(11.5, 14);
            double numZ = ReturnRoom(9, 9.5);
            double numY = ReturnRoom(11, 12.25);
            double numX = ReturnRoom(24, 20.25);
            Console.WriteLine(numZ + numY + numX); */

            PrintYourName();
            Subtraction(10, 3);
            Subtraction(4.2, 15.6);

            //the num
            double sub = ReturnSubtraction(20, 4);
            Console.WriteLine("Subtraction of 20 and 4: " + sub);


        }

        static void PrintYourName()
        {
            Console.WriteLine("Ethan Henson");
        }
        static void Subtraction(double a, double b)
        {
            double sub = a - b;
            Console.WriteLine("{0} - {1} is {2}", a, b, sub);
        }
        static double ReturnSubtraction(double a, double b)
        {
            double sub = a - b;
            return sub;
        }



        static void RoomA()
        {
            double numA = 13 * 10;
            Console.WriteLine("A 10 by 13 sized room needs {0} feet of carpet.", numA);
        }
        static void RoomB()
        {
            double numB = 8 * 12;
            Console.WriteLine("A 12 by 8 sized room needs {0} feet of carpet.", numB);
        }
        static void RoomMaker(double a, double b)
        {
            double numM = a * b;

            Console.WriteLine("A {1} by {2} sized room needs {0} feet of carpet.", numM, a, b);
        }
        static double ReturnRoom(double width, double length)
        {
            double area = width * length;
            return area;
        }

    }
}
