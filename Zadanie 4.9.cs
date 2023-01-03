namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Wprowadz tekst: ");
            tekst = Console.ReadLine();
            int liczbaWyrazów = 1;
            foreach (char litera in tekst)
                if (litera == ' ')
                    liczbaWyrazów++;
            Console.WriteLine("Wprowadzony tekst zawiera {0} wyrazow", liczbaWyrazów);
            Console.ReadKey();
        }
    }
}