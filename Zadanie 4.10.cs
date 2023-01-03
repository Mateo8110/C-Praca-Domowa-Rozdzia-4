namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj datę w formacie DD-MM-RRRR");
            string n;
            n = Console.ReadLine();
            string miesiąc;
         
            miesiąc = n.Substring(3, 2);

            switch (miesiąc)
            {
                case "01":
                    Console.WriteLine("Styczeń");
                    break;
                case "02":
                    Console.WriteLine("luty");
                    break;
                case "03":
                    Console.WriteLine("marzec");
                    break;
                case "04":
                    Console.WriteLine("kwiecien");
                    break;
                case "05":
                    Console.WriteLine("maj");
                    break;
                case "06":
                    Console.WriteLine("czerwiec");
                    break;
                case "07":
                    Console.WriteLine("lipiec");
                    break;
                case "08":
                    Console.WriteLine("sierpień");
                    break;
                case "09":
                    Console.WriteLine("wrzesien");
                    break;
                case "10":
                    Console.WriteLine("pazdziernik");
                    break;
                case "11":
                    Console.WriteLine("listopad");
                    break;
                case "12":
                    Console.WriteLine("grudzien");
                    break;
                default:
                    Console.WriteLine("Nieznana wartosc");
                    break;
            }
            Console.ReadKey();
        }
    }
}

            

        