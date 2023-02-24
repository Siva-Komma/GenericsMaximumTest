using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximaumTest
{
    public class Refactor2<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;
        public Refactor2(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;
        }

        public static T MaxValue(T firstvalue, T secondvalue, T thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
               firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
               firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("First value is bigger than other two values");
                return firstvalue;
            }
            if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(thirdvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("Second value is bigger than other two value");
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                Console.WriteLine("Third value is bigger than other two value");
                return thirdvalue;
            }
            return firstvalue;
        }

        public void NewTestCase()
        {
            T Value = MaxValue(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine("Maximum value is " + Value);

        }
    }
}

