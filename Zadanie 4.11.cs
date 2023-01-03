namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            string tekst = (Console.ReadLine());

            int a = 0;
            foreach (char litera in tekst)
                if (litera == 'a')
                    a++;

            int b = 0;
            foreach (char litera in tekst)
                if (litera == 'b')
                    b++;

            int c = 0;
            foreach (char litera in tekst)
                if (litera == 'c')
                    c++;

            int d = 0;
            foreach (char litera in tekst)
                if (litera == 'd')
                    d++;
            int e = 0;
            foreach (char litera in tekst)
                if (litera == 'e')
                    e++;

            int f = 0;
            foreach (char litera in tekst)
                if (litera == 'f')
                    f++;



            Console.WriteLine("Litera a wystąpiła {0} razy", a);
            Console.WriteLine("Litera b wystąpiła {0} razy", b);
            Console.WriteLine("Litera c wystąpiła {0} razy", c);
            Console.WriteLine("Litera d wystąpiła {0} razy", d);
            Console.WriteLine("Litera e wystąpiła {0} razy", e);
            Console.WriteLine("Litera f wystąpiła {0} razy", f);

            Console.ReadKey();
        }
    }
}










