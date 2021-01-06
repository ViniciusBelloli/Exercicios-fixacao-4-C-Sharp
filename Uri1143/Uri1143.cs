using System;

namespace Uri1143
{
   class Uri1143
   {
      static void Main(string[] args)
      {
         int nLer = int.Parse(Console.ReadLine());

         for (int i = 1; i <= nLer; i++)
         {
            int primeiro = i;
            int segundo  = i * i;
            int terceiro = i * i * i;
            Console.WriteLine($"{primeiro} {segundo} {terceiro}");
         }
      }
   }
}