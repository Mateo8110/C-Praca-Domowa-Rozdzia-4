namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę elementów w tablicy: ");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[rozmiar];
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + ", ");
            }
            Console.ReadKey();

        }
    }
}
