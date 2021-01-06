using System;
using System.Globalization;

namespace Uri1073
{
   class Uri1073
   {
      static void Main(string[] args)
      {
         int nLer = int.Parse(Console.ReadLine());
         double nota1, nota2, nota3, media;

         for (int i = 0; i < nLer; i++)
         {
            String[] valores = Console.ReadLine().Split(' ');

            nota1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
         }
      }
   }
}
