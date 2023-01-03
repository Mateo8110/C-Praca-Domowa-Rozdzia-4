namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[,] tab2d1 = { { 1, 2, 3, 4, 5 },
                                  { 6, 7, 8, 9, 10 },
                                  { 11, 12, 13, 14, 15 },
                                  { 16, 17, 18, 19, 20 },
                                  { 21, 22, 23, 24, 25 } };
                                  
            
            
            /*wszystkie elementy tablicy*/
            for (int a = 0; a < tab2d1.GetLength(0); a++)
            {
                for (int b = 0; b < tab2d1.GetLength(1); b++)
                {
                    Console.Write("{0,3}", tab2d1[a, b]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*elementy po skosie*/
            for (int a = 0; a < 1; a++)
            {
                for (int b = 0; b < 1; b++)
                {

                    Console.WriteLine("a[{0}, {1}] = {2}", a, b, tab2d1[a, b]);
                    suma += tab2d1[a, b];
                }
            }
            for (int a = 1; a < 2; a++)
            {
                for (int b = 1; b < 2; b++)
                {

                    Console.WriteLine("a[{0}, {1}] = {2}", a, b, tab2d1[a, b]);
                    suma += tab2d1[a, b];                }
            }
            for (int a = 2; a < 3; a++)
            {
                for (int b = 2; b < 3; b++)
                {

                    Console.WriteLine("a[{0}, {1}] = {2}", a, b, tab2d1[a, b]);
                    suma += tab2d1[a, b];
                }
            }
            for (int a = 3; a < 4; a++)
            {
                for (int b = 3; b < 4; b++)
                {

                    Console.WriteLine("a[{0}, {1}] = {2}", a, b, tab2d1[a, b]);
                    suma += tab2d1[a, b];
                }
            }
            for (int a = 4; a < 5; a++)
            {
                for (int b = 4; b < 5; b++)
                {

                    Console.WriteLine("a[{0}, {1}] = {2}", a, b, tab2d1[a, b]);
                    suma += tab2d1[a, b];
                }
            }
            /*Suma tych elentów*/
            Console.WriteLine("Suma elementów po przekątnej wynosi: {0}", suma);

            Console.ReadKey();
        }
    }
}

    