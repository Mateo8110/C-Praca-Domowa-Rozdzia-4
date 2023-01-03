using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 1;
            double srednia = 0;
            int suma = 0;
            int sumadod = 0;


            Console.WriteLine("Podaj liczbę elemntów tablicy: ");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            int[] tablica = new int[rozmiar];
            int[] tab2 = new int[rozmiar];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
                suma += tablica[i];
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                    max = tablica[i];
                else if (tablica[i] < min)
                    min = tablica[i];
            }
            Console.WriteLine("Największy element tablicy: {0}", max);
            Console.WriteLine("Pozycja największej wartosic tab to: {0}",Array.IndexOf(tablica, max)); 
            Console.WriteLine("Najmniejszy element tablicy: {0}", min);
            Console.WriteLine("Pozycja najmniejszej wartosci tablicy to: {0}", Array.IndexOf(tablica, min));

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > 0)
                    tab2[i] += tablica[i];
            }
            srednia = suma / tablica.Length;
            Console.WriteLine("Srednia elemntów wynosi: {0}", srednia);



            Console.WriteLine("ilosc dodatnich elementów w tablicy wynosi: ");
            for (int i = 0; i < tab2.Length; i++)
            {
                if (tab2[i] > 0)
                    sumadod += 1;
            }
            Console.WriteLine(sumadod);

            Console.ReadKey();
        }
    }
}