using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multicasstdelegate
{
    public delegate void demo();


    class Program
    {
        public static void Main(string[] args)
        {

            //creatoing the instances of the delegates
            demo d1 = new demo(display);

            //calls the delegate to perform the function

            d1();
            demo d2 = new demo(getdata);
            d2();
            demo d3 = new demo(setdata);
            d3();
            //concatinating the delegates
            demo d4 = d1 + d2 + d3;
            d4();
            Console.ReadKey();

                       
        }
        public static void display()
        {
            Console.WriteLine("This delegate DISPLAYS the data");           
        }
        public static void getdata()
        {
            Console.WriteLine("This delegate GETS the data");
        }
        public static void setdata()
        {
            Console.WriteLine("This delegate SETS the data");
        }
        
    }
}
