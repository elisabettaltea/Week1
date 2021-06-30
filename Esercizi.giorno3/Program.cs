using System;

namespace Esercizi.giorno3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] c = {1, 20, 35, 7, 40};
            //Console.WriteLine("Inserisci l'elemento da cercare");
            //int n = int.Parse(Console.ReadLine());
            ////int n = 35;

            //appartenenza(c, n);

            //void appartenenza(int[] vett, int elem)
            //{
            //    bool contenuto = true;

            //    foreach (int i in vett)
            //    {
            //        if (i == elem)
            //        {
            //            Console.WriteLine($"{elem} è contenuto nel vettore!");
            //            contenuto = false;
            //            break;
            //        }
            //    }
            //    if (contenuto)
            //    {
            //        Console.WriteLine($"{elem} non appartiene al vettore!");
            //    }
            //}

            //Scrivere una routine InsertNumbers che chiede all'utente di inserire 3 numeri interi diversi da 0
            //e li salva in un array e me lo restituisce.
            //Verificare che i numeri aggiunti dall'utente siano del formato corretto
            //e verificare che siano diversi da 0 con un'altra routine CheckIns, da chiamare in InsertNumbers.


            int[] array = new int[3];
            InsertNumber(ref array);

            Console.WriteLine();
            Console.WriteLine("Il tuo vettore formato da 3 numeri interi diversi da zero è ");
            foreach (int i in array)
            {
                Console.WriteLine($"{i} ");
            }

            void InsertNumber(ref int[] a)
            {
               
                for (int i=0; i<3; i++)
                {
                    Console.WriteLine($"Inserisci l'elemento {i}-esimo del vettore:");
                    int s = CheckIns(int.TryParse(Console.ReadLine(), out int result), result);
                    a[i] = s;
                }
                
            }

            int CheckIns(bool verifica, int result)
            {
                while (!(verifica && result!=0))
                {
                    Console.WriteLine("Valore inserito errato, riprova! Inserisci un numero intero diverso da 0:");
                    verifica = int.TryParse(Console.ReadLine(), out int res);
                    result = res;
                }
                return result;    
            }
        }
    }
}

