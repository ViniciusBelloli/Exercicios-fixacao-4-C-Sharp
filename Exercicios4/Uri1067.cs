using System;

namespace Exercicios4
{
   class Uri1067
   {
      static void Main(string[] args)
      {
         int n1 = int.Parse(Console.ReadLine());

         for (int i = 0; i <= n1; i++)
         {
            if (!(i % 2 == 0))
            {
               Console.WriteLine(i);
            }
         }
      }
   }
}