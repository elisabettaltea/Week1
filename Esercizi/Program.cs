using System;

namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
