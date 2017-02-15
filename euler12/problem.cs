using System.Collections.Generic;
using System;

namespace TriangleProblem
{
    class TriangleSolver
    {
        public static void Main()
        {
            Console.WriteLine("Going");
            Console.WriteLine(TriangleCounter().ToString());
        }

        public static bool ProductTally(ulong number)
        {
            int productCounter = 0;
            for (ulong index = 1; index*index <= number; index++)
            {
                if (number % index == 0)
                {
                    productCounter += 2;
                }
            }
            if (productCounter > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ulong TriangleCounter()
        {
            ulong triangleNumber = 1;
            ulong triangleCounter = 2;
            while (!ProductTally(triangleNumber))
            {
                triangleNumber += triangleCounter;
                triangleCounter += 1;
            }
            return triangleNumber;
        }
    }
}
