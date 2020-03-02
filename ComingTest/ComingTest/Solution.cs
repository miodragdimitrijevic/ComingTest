using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComingTest
{
   public class Solution
    {
        public Solution()
        {

        }
        //zadatak 1
        public void swapVariables()
        {
            int a = 1;
            int b = 5;
            Console.WriteLine("Stara vrednost a je " + a + "a stara vrednost b je" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Nova vrednost a je " + a + " a nova vrednost b je " + b);

        }
        //zadatak 2
        public int solution(int[] A)
        {
            int minimum = min(A);
            bool flag = false;
            minimum++;
            while (flag == false)
            {
                if (!isMemberofArray(minimum, A))
                {
                    flag = true;

                }
                else
                {
                    minimum++;

                }
            }
            return minimum;
        }
        public int min(int[] A)
        {
            int minel = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= minel && A[i] > 0)
                {
                    minel = A[i];
                }
            }
            return minel;
        }

        public bool isMemberofArray(int el, int[] A)
        {

            foreach (int e in A)
            {
                if (e == el)
                    return true;
            }
            return false;
        }
        //zadatak 3
        public int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fact(n - 1);
        }
    }
}
