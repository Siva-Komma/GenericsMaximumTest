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
            Console.WriteLine("1.MaxInteger\n2.MaxFloat\n3.MaxString\n4.Refactor1\n5.Refactor2\n6.ExtendMaxMethod");
            Console.WriteLine("Choose Your Option");
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
                case 3:
                    MaxString.MaxStringtValue("Peach","Apple","Banana");
                    MaxString.MaxStringtValue("Apple", "Peach", "Banana");
                    MaxString.MaxStringtValue("Apple","Banana","Peach");
                    break;
                case 4:
                    Refactor1<int>.MaxValue(100, 200, 300);
                    Refactor1<float>.MaxValue(10.4f, 1.4f, 56.3f);
                    Refactor1<string>.MaxValue("Peach", "Bonana", "Apple");
                    break;
                case 5:
                    Refactor2<int> refactor = new Refactor2<int>(100, 200, 300);
                    Refactor2<float> refactor1 = new Refactor2<float>(10.34f, 56.2f, 101.54f);
                    Refactor2<string> refactor2 = new Refactor2<string>("Banana", "Apple", "Peach");
                    refactor.NewTestCase();
                    refactor1.NewTestCase();
                    refactor2.NewTestCase();
                    break;
                case 6:
                    ExtendMaxMethod<int>.ExtendMaxValue(700, 200, 300,500);
                    ExtendMaxMethod<float>.ExtendMaxValue(10.4f, 1.4f, 56.3f,100.4f);
                    ExtendMaxMethod<string>.ExtendMaxValue("Peach", "Banana", "Apple","Mango");
                    break;
            }
            Console.ReadLine();
        }
    }
}
