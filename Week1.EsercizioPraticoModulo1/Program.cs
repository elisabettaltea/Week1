using System;

namespace Week1.EsercizioPraticoModulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto a Tombola!");

            do
            {
                //scelta dei 15 numeri da parte del giocatore
                int[] chosenNumbers = InsertNumbers();

                //scelta del livello di difficoltà
                int dl = DifficultyLevel();

                //estrazione dei numeri in base alla difficoltà scelta
                int[] drawnNumbers = DrawnNumbers(dl);

                //verifica della vittoria
                CheckWin(chosenNumbers, drawnNumbers);

                //il giocatore può decidere se tentare di nuovo la fortuna e rigiocare a tombola
                Console.WriteLine("\nVuoi rigiocare? Premi 'Q' per uscire oppure qualunque altro per continuare");

            } while (!(Console.ReadKey().KeyChar == 'Q'));



            //Funzione per la scelta dei 15 numeri
            int[] InsertNumbers()
            {
                Console.WriteLine("\nInserisci i 15 numeri con cui vuoi giocare: ");

                int[] array = new int[15];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Inserisci il {i + 1}° numero"); //in questo caso l'articolo 'il' non va bene per l'ottavo e l'undicesimo numero

                    int n = CheckIns();

                    //la verifica che non ci siano duplicati si potrebbe fare in un altro metodo esterno
                    int found = -1;

                    found = Array.IndexOf(array, n);

                    if (found > -1)
                    {
                        Console.WriteLine($"Il numero {n} è già stato scelto! Inserisci un altro numero");
                        i--;
                    }
                    else
                    {
                        array[i] = n;
                    }
                }

                Console.WriteLine("Hai scelto i seguenti numeri: ");
                foreach (int i in array)
                {
                    Console.Write($"{i} ");
                }

                return array;
            }

            //Funzione per la scelta del livello di difficoltà: 70, 40, 20
            //(per farla più semplice basterebbe chiedere di inserire 70 per livello di difficoltà 'facile',
            //40 per livello di difficoltà 'medio', 20 per livello di difficoltà 'difficile')
            int DifficultyLevel()
            {
                Console.WriteLine("\n\nScegli il livello di difficoltà:\n1 per Facile\n2 per Medio\n3 per Difficile");

                int n = CheckInsD();

                int d = 0;

                switch (n)
                {
                    case 1:
                        d = 70;
                        Console.WriteLine("Hai scelto il livello di difficoltà 'Facile'");
                        break;
                    case 2:
                        d = 40;
                        Console.WriteLine("Hai scelto il livello di difficoltà 'Medio'");
                        break;
                    case 3:
                        d = 20;
                        Console.WriteLine("Hai scelto il livello di difficoltà 'Difficile'");
                        break;
                }

                return d;
            }

            //Funzione per l'estrazione dei numeri in base alla difficoltà scelta
            int[] DrawnNumbers(int d)
            {
                Console.WriteLine("\nNumeri estratti: ");

                int[] numbers = new int[d];

                Random random = new Random();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int drawn = random.Next(1, 91);

                    //la verifica che non ci siano duplicati tra i numeri estratti si potrebbe fare in un altro metodo esterno,
                    //diverso da quello che servirebbe per verificare che non ci siano duplicati tra i numeri scelti dal giocatore,
                    //perchè in quel caso viene chiesto di inserire un altro numero, qui viene estratto un altro numero
                    int found = -1;

                    found = Array.IndexOf(numbers, drawn);

                    if (found > -1)
                    {
                        i--;
                    }
                    else
                    {
                        numbers[i] = drawn;
                        Console.Write($"{drawn} ");
                    }

                }

                return numbers;
            }

            //Procedura per il controllo della vittoria 
            void CheckWin(int[] chosen, int[] drawn)
            {
                //ricerca dei numeri in comune tra quelli scelti dal giocatore e quelli estratti
                int found = -1;

                int[] winning = new int[chosen.Length];

                for (int i = 0; i < chosen.Length; i++)
                {
                    found = Array.IndexOf(drawn, chosen[i]); 

                    if (found > -1) 
                    {
                        winning[i] = drawn[found];
                    }
                }

                int count = 0;
                Console.WriteLine("\nI tuoi numeri che sono stati estratti sono ");
                foreach (int i in winning)
                {
                    
                    if (i != 0)
                    {
                        Console.Write($"{i} "); ;
                        count++;
                    }
                }

                Console.WriteLine($"\nSono stati estratti {count} dei tuoi numeri!");

                //Si perde se vengono estratti meno di 2 dei numeri scelti, se vengono estratti tra i 5 e i 14 numeri scelti dal giocatore
                //si fa cinquina
                if (count < 2)
                {
                    Console.WriteLine("Hai perso!");
                }
                else if (count == 2)
                {
                    Console.WriteLine("Hai fatto ambo!");
                }
                else if (count == 3)
                {
                    Console.WriteLine("Hai fatto terna!");
                }
                else if (count == 4)
                {
                    Console.WriteLine("Hai fatto quaterna!");
                }
                else if (count >= 5 && count < 15)
                {
                    Console.WriteLine("Hai fatto cinquina!");
                }
                else
                {
                    Console.WriteLine("Hai fatto tombola!");
                }

                ////Alternativa(si perde se vengono estratti meno di 2 dei numeri scelti,
                ////se vengono estratti 2 numeri scelti dal giocatore si fa ambo,
                ////se vengono estratti 3 numeri scelti dal giocatore si fa terna e ambo,
                ////se vengono estratti 4 numeri scelti dal giocatore si fa quaterna, terna e ambo,
                ////se vengono estratti tra i 5 e i 14 numeri scelti dal giocatore si fa cinquina, quaterna, terna e ambo,
                ////se vengono estratti tutti i 15 numeri scelti dal giocatore si fa tombola!)
                //if (count < 2)
                //{
                //    Console.WriteLine("Hai perso!");
                //}
                //else if (count == 2)
                //{
                //    Console.WriteLine("Hai fatto ambo!");
                //}
                //else if (count == 3)
                //{
                //    Console.WriteLine("Hai fatto terna e ambo!");
                //}
                //else if (count == 4)
                //{
                //    Console.WriteLine("Hai fatto quaterna, terna e ambo!");
                //}
                //else if (count >= 5 && count < 15)
                //{
                //    Console.WriteLine("Hai fatto cinquina, quaterna, terna e ambo!");
                //}
                //else
                //{
                //    Console.WriteLine("Hai fatto tombola!");
                //}

                ////Alternativa(si perde se vengono estratti meno di 2 oppure tra i 6 e i 14 dei numeri scelti dal giocatore)
                //switch (count)
                //{
                //    case 2:
                //        Console.WriteLine("Hai fatto ambo!");
                //        break;
                //    case 3:
                //        Console.WriteLine("Hai fatto terna!");
                //        break;
                //    case 4:
                //        Console.WriteLine("Hai fatto quaterna!");
                //        break;
                //    case 5:
                //        Console.WriteLine("Hai fatto cinquina!");
                //        break;
                //    case 15:
                //        Console.WriteLine("Hai fatto tombola!");
                //        break;
                //    default:
                //        Console.WriteLine("Hai perso!");
                //        break;
                //}

            }

            //Funzione che controlla che il giocatore scelga solo numeri interi compresi fra 1 e 90
            int CheckIns()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 90)
                {
                    Console.WriteLine("Puoi inserire solo numeri interi compresi tra 1 e 90! Riprova:");
                }

                return num;
            }

            //Funzione che controlla che il giocatore scelga un valore accettabile per il livello di difficoltà
            int CheckInsD()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 3)
                {
                    Console.WriteLine("Puoi inserire solo un numero a scelta tra 1, 2 e 3! Riprova:");
                }

                return num;
            }


        }
    }
}
