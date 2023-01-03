namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[2, 0] = "środa";
            dniTygodnia[3, 0] = "Czwartek";
            dniTygodnia[4, 0] = "Piątek";
            dniTygodnia[5, 0] = "Sobota";
            dniTygodnia[6, 0] = "Niedziela";

            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[6, 1] = "sunday";

            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 2] = "sonntag";

            for (int i = 0; i < dniTygodnia.GetLength(0); i++)
            {
                for (int j = 0; j < dniTygodnia.GetLength(1); j ++) 
                {
                    Console.Write("\n {0,3}", dniTygodnia[i, j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
