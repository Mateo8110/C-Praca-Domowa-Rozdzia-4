namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            string[] tab = { "komp-2010", "lap-2012", "ps-2014", "xbox-2018", "lodowka-2021" };
            string[] sub;
            var str = String.Join("-", tab);
            Console.WriteLine(str);

            sub = str.Split('-');

            for (int i = 0; i < sub.Length; i++)
            {
                Console.Write("Dla produktu ");
                Console.Write(sub[i]);
                Console.Write(" data zakupu to: ");
                i += 1;
                Console.Write(sub[i]);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}




