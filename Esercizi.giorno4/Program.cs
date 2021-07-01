using System;

namespace Esercizi.giorno4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio
            //Scrivere un programma completo. L'utente inserisce un numero tra 2 e 12.
            //Il computer lancia 2 dadi, quindi sorteggia 2 numeri random tra 1 e 6.
            //Se la somma dei due numeri random è pari al numero scelto dall'utente, l'utente vince
            //Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
            //Finita la partita l'utente deve poter rigiocare.
            //Requisiti: verificare che l'utente inserisca un intero e che sia compreso tra 2 e 12.
            //Se la verifica non va a buon fine, l'utente deve potere inserire nuovamente qualcosa.
            //Suggerimento: creare un metodo per l'inserimento dei numeri e la verifica,
            //uno per il controllo della vittoria(da chiamare nel main).



            do
            {
                tentativo(out int number, out int sum);

                verificaVittoria(number, sum);

                Console.WriteLine("Vuoi continuare? s per si");
                
            }
            while (Console.ReadKey().KeyChar == 's');


            void tentativo(out int number, out int sum)
            {
                Console.WriteLine("Inserisci un numero tra 2 e 12:");

                number = CheckIns();
                //Console.WriteLine($"Hai inserito il numero {number}!");

                Random random = new Random();
                //int randomNum = random.Next(2, 13);
                //Console.WriteLine($"Il numero sorteggiato è {randomNum}!");
                int randomNum1 = random.Next(1, 7);
                //Console.WriteLine($"Il primo numero sorteggiato è {randomNum1}!");
                int randomNum2 = random.Next(1, 7);
                //Console.WriteLine($"Il secondo numero sorteggiato è {randomNum2}!");
                sum = randomNum1 + randomNum2;
                //Console.WriteLine($"La somma dei numeri sorteggiati è {sum}!");

            }


            int CheckIns()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num < 2 || num > 12)
                {
                    Console.WriteLine("Puoi inserire solo interi compresi tra 2 e 12! Riprova:");
                }

                return num;
            }


            void verificaVittoria(int number, int sum)
            {
                if (number == sum)
                {
                    Console.WriteLine("Hai vinto!!!");
                }
                else
                {
                    Console.WriteLine("Hai perso :(");
                }
            }

        }
    }
}
