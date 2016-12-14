using System;
using System.Linq;

namespace Ronnahcate.Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if( args.Length != 1 )
            {
                Console.WriteLine("Please put heights as string array separate by comma!!!");
                Console.WriteLine("eg. dotnet run 3,2,1,2,3");
            }
            else
            {
                var heightList = args[0].Split(',').Select(int.Parse).ToList();
                Console.WriteLine("Result is " + Container.GetContainerSize(heightList));
            }
        }
    }
}
