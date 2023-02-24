using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximaumTest
{
    class ExtendMaxMethod<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue,fourthvalue;
        public static T ExtendMaxValue(T firstvalue, T secondvalue, T thirdvalue,T fourthvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 && firstvalue.CompareTo(fourthvalue) > 0 ||
               firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 && firstvalue.CompareTo(fourthvalue) >= 0 ||
               firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0 && firstvalue.CompareTo(fourthvalue) > 0 )
            {
                Console.WriteLine("First value is bigger than other three values");
                return firstvalue;
            }
            if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(fourthvalue)>0 ||
                secondvalue.CompareTo(thirdvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(fourthvalue) >= 0 ||
                secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0 && secondvalue.CompareTo(fourthvalue) > 0)
            {
                Console.WriteLine("Second value is bigger than other three value");
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 && thirdvalue.CompareTo(fourthvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 && thirdvalue.CompareTo(fourthvalue) >= 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0 && thirdvalue.CompareTo(fourthvalue) > 0)
            {
                Console.WriteLine("Third value is bigger than other three value");
                return thirdvalue;
            }
            if (fourthvalue.CompareTo(firstvalue) > 0 && fourthvalue.CompareTo(secondvalue) > 0 && fourthvalue.CompareTo(thirdvalue) > 0 ||
               fourthvalue.CompareTo(firstvalue) >= 0 && fourthvalue.CompareTo(secondvalue) > 0 && fourthvalue.CompareTo(thirdvalue) >= 0 ||
               fourthvalue.CompareTo(firstvalue) > 0 && fourthvalue.CompareTo(secondvalue) >= 0 && fourthvalue.CompareTo(thirdvalue) > 0)
            {
                Console.WriteLine("Fourth value is bigger than other three value");
                return fourthvalue;
            }
            return firstvalue;
        }
    }
}
