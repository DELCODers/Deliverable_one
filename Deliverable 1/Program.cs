using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double inches = 3.5f;
            double foot = 5f;
            double fidget_spinner = 3.5f;
            double meme = 5;


            Console.WriteLine("Please input a  measurement type");
            string measurMent = Console.ReadLine();

            Console.WriteLine("Please input an amount");
            double num1 = double.Parse(Console.ReadLine());


            double covertedNum = 0;
            if (measurMent == "inch")
            {
                inches = num1 * 3.5d;

                Console.WriteLine(num1 * 3.5d + "fidget spinners");

            }



            if (measurMent == "foot")
            {
                meme = num1 * 5f;

                Console.WriteLine(5f * num1 + "memes");
            }

            {
                if (measurMent == "fidget spinners")
                {
                    fidget_spinner = num1 / 3.5f;

                    Console.WriteLine(num1 / 3.5f + "inches");
                }

                {
                    if (measurMent == "meme")
                    {
                        foot = num1 / 5f;

                        Console.WriteLine(num1 / 5f + "feet");
                    }
                }
            }
        }
    }
}