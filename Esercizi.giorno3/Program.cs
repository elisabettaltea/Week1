using System;
using System.Collections;
using System.Collections.Generic;

namespace Esercizi.giorno3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Esercizio 0

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



            ////Esercizio 1
            ////Scrivere una routine InsertNumbers che chiede all'utente di inserire 3 numeri interi diversi da 0
            ////e li salva in un array e me lo restituisce.
            ////Verificare che i numeri aggiunti dall'utente siano del formato corretto
            ////e verificare che siano diversi da 0 con un'altra routine CheckIns, da chiamare in InsertNumbers.


            //int[] array = new int[3];
            //InsertNumber(ref array);

            //Console.WriteLine();
            //Console.WriteLine("Il tuo vettore formato da 3 numeri interi diversi da zero è ");
            //foreach (int i in array)
            //{
            //    Console.WriteLine($"{i} ");
            //}

            //void InsertNumber(ref int[] a)
            //{

            //    for (int i=0; i<3; i++)
            //    {
            //        Console.WriteLine($"Inserisci l'elemento {i}-esimo del vettore:");
            //        int s = CheckIns(int.TryParse(Console.ReadLine(), out int result), result);
            //        a[i] = s;
            //    }

            //}

            //int CheckIns(bool verifica, int result)
            //{
            //    while (!(verifica && result!=0))
            //    {
            //        Console.WriteLine("Valore inserito errato, riprova! Inserisci un numero intero diverso da 0:");
            //        verifica = int.TryParse(Console.ReadLine(), out int res);
            //        result = res;
            //    }
            //    return result;    
            //}



            //Esercizio2

            //Scrivere una routine che, dati due array, verifichi quali sono gli elementi in comune,
            //ovvero presenti in entrambi gli array, e stampare solo gli elementi in comune. 
            //Se non ci sono elementi in comune, stampare 'Non ci sono elementi in comune'.

            int[] a1 = { 1, 2, 3 };

            //int[] b1 = { 4, 7, 9 };
            int[] b1 = { 4, 2, 9 };
            //int[] b1 = { 4, 2, 1 };

            cerca(a1, b1);

            void cerca(int[] a, int[] b)
            {
                ArrayList inComune = new ArrayList() { };

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            inComune.Add(a[i]);
                        }

                    }
                }

                if (inComune.Count > 0)
                {
                    Console.WriteLine("Gli elementi in comune fra i due vettori sono:");
                    foreach (int i in inComune)
                    {
                        Console.Write($"{i} ");
                    }
                }
                else
                {
                    Console.Write("I due vettori non hanno elementi in comune!");
                }
            }



            //Esercizio 3
            //Scrivere una routine che chiede all'utente di scrivere i giorni della settimana (Es. Lun Mar Mer Gio Ven Sab Dom).
            //Se l'utente ha già inserito un giorno, stampare 'Hai già inserito questo giorno' e far inserire  nuovo.
            //Infine, stampare i giorni nell'ordine in cui l'utente li ha inseriti. 
        }
    }
}

