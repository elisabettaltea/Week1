using System;

namespace Esercizi4e5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Esercizio4
            int[] array = { 3, 6, 2, 7, 8 };
            int l = array.Length;

            for (int i = 0; i < l - 1; i++)
            {
                for (int j = 0; j < l - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            for (int ind = 0; ind < l; ind++)
            {
                Console.WriteLine(array[ind]);
            }

            //Esercizio5
            //string p = "mozzarella";
            string p = "sottilissimo";
            int lu = p.Length;

            int[] count = new int[lu];

            for (int i = 0; i < lu; i++)
            {
                for (int j = 0; j < lu; j++)
                {
                    if (p[i] == p[j])
                    {
                        count[i]=++count[i];
                    }
                }
            }

            for (int index = 0; index < lu; index++)
            {
                if (count[index]==1)
                {
                    Console.WriteLine($"La prima lettera che non si ripete è {p[index]}!");
                    break;
                }
            }

        }
    }
}
