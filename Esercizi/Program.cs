using System;

namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio1
            int c = 0;
            do
            {
                Console.WriteLine("Inserisci il primo numero");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Scegli l'operazione da fare tra il primo e il secondo numero");
                Console.WriteLine("1 Somma \n2 Sottrazione \n3 Moltiplicazione \n4 Divisione");
                int choice = int.Parse(Console.ReadLine());

                int result;

                switch (choice)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{result}");
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{result}");
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{result}");
                        break;
                    case 4:
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{result}");
                        break;
                }

                Console.WriteLine("Vuoi continuare?");
                Console.WriteLine("0 per si \n1 per no");
                c = int.Parse(Console.ReadLine());
            }
            while (c == 0);

            //Esercizio2
            int cont = 0;
            string s = "mattinata";
            char let = 'a';

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == let)
                {
                    ++cont;
                }
            }
            Console.WriteLine($"La lettera {let} compare {cont} volte nella stringa \"mattinata\"!");

            //Esercizio3
            //int[] arrayOrd = new int[5];
            int[] array = { 3, 6, 2, 7, 8 };

            for (int ind = 0; ind < array.Length; ind++)
            {
                Console.WriteLine(array[ind]);
            }

            //Console.WriteLine($"L'elemento in posizione 1 è {array[0]}");
            //Console.WriteLine($"L'elemento in posizione 3 è {array[2]}");

            //int t = 0;
            //for (int i = 1; i < 5; i++)
            //{
            //    for (int j = 3; j >= i; j--)
            //    {
            //        if (array[j - 1] > array[j]) //(array[j-1]<array[j])
            //        {
            //            //arrayOrd[j - 1] = array[j - 1];
            //            //arrayOrd[j] = array[j];

            //            t = array[j - 1];
            //            array[j - 1] = array[j];
            //            array[j] = array[j - 1];
            //        }
            //        //else
            //        //{
            //        //    arrayOrd[j - 1] = array[j];
            //        //    arrayOrd[j] = array[j - 1];
            //    }
            //}

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

            //Esercizio4
            //string str = "innamorati";
            //int lung = str.Length;
            //int[] arrayCont = new int[lung];

            //for (int index = 0; index < lung ; index++)
            //{
            //    cont = 0;
            //    for (int jnd = 0; jnd < l - index - 1; jnd++)
            //    if (str[index] == str[jnd])
            //    {
            //        cont++;
            //    }
            //}
            //Console.WriteLine($"La lettera {let} compare {cont} volte nella stringa \"mattinata\"!");
            
            string str = "mattinata";
            int lung = str.Length;
            
            for (int jndex = 0; jndex < lung; jndex++)
            {
                cont = 0;
                for (int index = 0; index < lung - jndex - 1; index++)
                {
                    if (s[index] != s[jndex])
                    {
                        ++cont;
                    }
                }
                if (cont == 0)
                {
                    Console.WriteLine($"La lettera cercata è {cont}");
                }

            }
            Console.WriteLine($"La lettera {let} compare {cont} volte nella stringa \"mattinata\"!");



        }
    }

}


