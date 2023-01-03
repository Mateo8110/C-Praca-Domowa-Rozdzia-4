namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {

            int[] tab1 = new int[10];
            int[] tab2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab1[i] = Convert.ToInt32(Console.ReadLine());

                 
               for (int j = tab1.Length - 1; j >= 0; j--)
               {
                   if (tab1[j] > 0)
                       tab2[j] += tab1[j];
               }
           
            }
            Console.WriteLine("Dodatnie liczby to: ");
            for (int i = 0; i < tab2.Length; i++)
            {
                if (tab2[i] > 0)
                    Console.Write(tab2[i] + ", ");
            }
         Console.ReadKey();
        }
    }
}