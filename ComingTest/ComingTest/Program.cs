using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ComingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { -1, 1, 2, 4};
            Solution solution = new Solution();
            Console.WriteLine("Resenje prvog zadatka:");
            solution.swapVariables(); //prvi zadatak;

            Console.WriteLine("Resenje drugog zadtka: ");
            //drugi zadatak;
            int rezultatDrugiZadatak =solution.solution(A);
            Console.WriteLine("Najmanja vrednost koja nije sadrzana u datom nizu A a veca je od nule je "
                + rezultatDrugiZadatak);

            Console.WriteLine("Resenje treceg zadatka:");
            //treci zadatak
           int faktorijel= solution.fact(5);
            Console.WriteLine("Faktorijel zadatog broja je " + faktorijel);
            
          
           
            
        }

        
    }
}
