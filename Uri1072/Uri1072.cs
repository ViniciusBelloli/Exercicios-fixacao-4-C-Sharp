using System;

namespace Uri1072
{
   class Uri1072
   {
      static void Main(string[] args)
      {
         int nLer = int.Parse(Console.ReadLine());
         int n1 = 0, nIn = 0, nOut = 0;

         for (int i = 0; i < nLer; i++)
         {
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 10 && n1 <= 20)
            {
               nIn++;
            }
            else
            {
               nOut++;
            }
         }

         Console.WriteLine(nIn + " in");
         Console.WriteLine(nOut + " out");
      }
   }
}
