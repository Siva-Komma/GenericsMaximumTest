using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximaumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics");
            Console.WriteLine("1.MaxInteger");
            Console.WriteLine("Choose Your Option\n2.MaxFloat");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    MaxInteger.MaxIntegerNumber(100, 20, 30);
                    MaxInteger.MaxIntegerNumber(20, 40, 30);
                    MaxInteger.MaxIntegerNumber(10, 20, 30);
                    break;
                case 2:
                    FloatMax.MaxFloatNumber(34.5f, 20.45f, 30.63f);
                    FloatMax.MaxFloatNumber(20.22f, 20.23f, 10.4f);
                    FloatMax.MaxFloatNumber(10.34f, 20.34f, 30.54f);
                    break;
            }
            Console.ReadLine();
        }
    }
}
