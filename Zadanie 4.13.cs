namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            string[] tablicaSlow = text.Split();
            int licznik = 1;

            for (int x = 0; x < tablicaSlow.Length; x++)
            {
                for (int y = 0; y < tablicaSlow.Length; y++)
                {
                    if (tablicaSlow[x].Equals(tablicaSlow[y]) == true && y != x)
                    {
                        tablicaSlow[y] = "null";
                        if (tablicaSlow[x] == "null")
                        {
                            licznik -= 2;
                        }
                        licznik++;
                    }
                }
                if (licznik > 0)
                {
                    tablicaSlow[x] = tablicaSlow[x] + " - " + licznik + " raz-y ";
                }
                licznik = 1;
            }
            foreach (var x in tablicaSlow.Distinct())
            {
                if (x != "null")
                {
                    Console.Write(x);
                }
                licznik++;
            }
            Console.ReadKey();
        }
    }
}