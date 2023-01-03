namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int[,] tab1 = { { 2, 3, 6 }, { 4, 5 , 0} };
            int[,] tab2 = { { 5, 6, 9 }, { 1, 6, 1 } };
            int[,] wynik = new int[2, 3];

            /*Elementy 1 tablicy*/
            Console.WriteLine("Tablica 1: ");
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int a = 0; a < tab1.GetLength(1); a++)
                {
                    Console.Write("{0,3}", tab1[i, a]);
                    wynik[i, a] += tab1[i, a];
                }
                Console.WriteLine();
            }
            Console.WriteLine("tablica 2: ");
            /*elementy 2 tablicy*/
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int a = 0; a < tab2.GetLength(1); a++)
                {
                    Console.Write("{0,3}", tab2[i, a]);
                    wynik[i, a] += tab2[i, a];
                }
                Console.WriteLine();
            }
            /*elenty 3 tablicy */
            Console.WriteLine("Suma dodania 2 tablic: ");
            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int a = 0; a < wynik.GetLength(1); a++)
                {
                    Console.Write("{0,3}", wynik[i, a]);
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
