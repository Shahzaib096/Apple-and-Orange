using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            int AppleCount = 0;
            int orangeCount = 0;
            Console.Write("Enter Start Point :");
            int Start = int.Parse(Console.ReadLine());
            Console.Write("Enter End Point :");
            int End = int.Parse(Console.ReadLine());
            Console.Write("Enter Distance of Apple :");
            int appleDistance = int.Parse(Console.ReadLine());
            Console.Write("Enter Distance of Orange :");
            int orangeDistance = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Apples :");
            int apples = int.Parse(Console.ReadLine());
            int[] myApples = new int[apples];
            for (int row = 0; row < apples; row++)
            {
                Console.Write("Enter Apples At Position {0} :",row);
                myApples[row] = int.Parse(Console.ReadLine());
            }
            for (int row=0;row<apples;row++)
            {
                myApples[row] += apples;
                if(myApples[row]>=Start && myApples[row]<=End)
                {
                    AppleCount++;
                }
            }
            Console.Write("Enter Number of Oranges :");
            int oranges = int.Parse(Console.ReadLine());
            int[] myOranges = new int[oranges];
            for (int row = 0; row < oranges; row++)
            {
                Console.Write("Enter Orange At Position {0} :", row);
                myOranges[row] = int.Parse(Console.ReadLine());
            }
            for (int row=0;row<oranges;row++)
            {
                myOranges[row] += oranges;
                if(myOranges[row]>=Start && myOranges[row]<=End)
                {
                    orangeCount++;
                }
            }
            Console.WriteLine("Number of Apples Are :" + AppleCount);
            Console.WriteLine("Number of Oranges Are :"+orangeCount);
            Console.ReadLine();
        }
    }
}
