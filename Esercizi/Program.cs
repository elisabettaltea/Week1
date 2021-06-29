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
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        break;
                    case 4:
                        result = firstNumber / secondNumber;
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
            char l = 'a';

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == l)
                {
                    ++cont;
                }
            }
            Console.WriteLine($"La lettera {l} compare {cont} volte nella stringa \"mattinata\"!");

            //Esercizio3
            int[] arrayOrd = new int[5];
            int[] array = { 3, 6, 2, 7, 8 };

            for (int ind = 0; ind < array.Length; ind++)
            {
                Console.WriteLine(array[ind]);
            }

            //Console.WriteLine($"L'elemento in posizione 1 è {array[0]}");
            //Console.WriteLine($"L'elemento in posizione 3 è {array[2]}");

            for (int i=1; i<5; i++)
            {
                for (int j=1; j<=i; j++)
                    if (array[j-1]<array[j])
                    {
                        arrayOrd[j-1] = array[j-1];
                        arrayOrd[j] = array[j];
                    }
                    else
                    {
                        arrayOrd[j-1] = array[j];
                        arrayOrd[j] = array[j-1];
                    }
            }

            for (int ind = 0; ind < arrayOrd.Length; ind++)
            {
                Console.WriteLine(arrayOrd[ind]);
            }

        }
    }
}
