using System.Globalization;

namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[100];
            int suma = 0;
            int k = 0;
            
            

            Random rand = new Random();

            Console.WriteLine("Wszystkie wylosowane liczby: ");
            for (int i = 0; i < 100; i++)
            {
                tablica[i] = rand.Next(1, 1000);
                Console.Write("{0,8}", tablica[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Liczby pierwsze w tablicy: ");

            for (int i = 0; i < tablica.Length; i++)
            {
                for (k = 2; k < tablica.Length; k++)
                    if (tablica[i] % k == 0)
                    {
                        tablica[i] = 0;
                        break;
                    }
                if (tablica[i] > 0)
                    Console.Write("{0,8}", tablica[i]); 
                
                {
                    if (tablica[i] > 0)
                        tablica[i] = 0 + 1;
                    suma += tablica[i];
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("W podanym zakresie znajduje się {0} liczb pierwszych", suma);
            Console.ReadKey();
        }
        
    }
}
    


        
        
    

               
            


        
    



