using System;

namespace Uri1157
{
   class Uri1157
   {
      static void Main(string[] args)
      {
         int n1 = int.Parse(Console.ReadLine());

         for(int i = 1; i <= n1; i++)
         {
            if(n1 % i == 0)
            {
               Console.WriteLine(i);
            }
         }
      }
   }
}