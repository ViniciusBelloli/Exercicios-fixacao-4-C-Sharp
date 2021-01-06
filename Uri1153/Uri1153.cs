using System;

namespace Uri1153
{
   class Uri1153
   {
      static void Main(string[] args)
      {
         int n1 = int.Parse(Console.ReadLine());
         if (n1 == 0)
         {
            n1 = 1;
         }

         int soma = n1;

         for (int i = 1; i < n1; i++)
         {
            soma *= (n1 - i);
         }

         Console.WriteLine(soma);
      }
   }
}
