using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximaumTest
{
    class FloatMax
    {
        public static float MaxFloatNumber(float firstvalue, float secondvalue, float thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("First number is bigger than other two numbers");
                return firstvalue;
            }
            if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(thirdvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("Second number is bigger than other two numbers");
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                Console.WriteLine("Third number is bigger than other two numbers");
                return thirdvalue;
            }
            return firstvalue;
        }
    }
}

