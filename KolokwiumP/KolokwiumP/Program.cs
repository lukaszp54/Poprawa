using System;

namespace KolokwiumP
{
    class Program
    {
        static bool Zadanie1(double x, double y)
        {
            if (x <= 1 && x > -1 && y <= 1 && y > -1)
            {
                double wynik = x * x + y * y;

                if (wynik <= 1)
                {
                    Console.WriteLine("Nalezy do kola");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nie nalezy do kola");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("Nieodpowiednie wspolrzedne");
                return false;
            }

        }



        static void Zadanie2()
        {
            int[] tab = new int[10];
            Random losowa = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = losowa.Next(1, 5);
                Console.Write($"{tab[i]} ");
            }
            int licznik1 = 0;
            int licznik2 = 0;
            int licznik3 = 0;
            int licznik4 = 0;
            int licznik5 = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                if (tab[i]==1)
                {
                    licznik1++;
                }
                if (tab[i] == 2)
                {
                    
                    licznik2++;
                }
                if (tab[i] == 3)
                {
                    
                    licznik3++;
                }
                if (tab[i] == 4)
                {
                    
                    licznik4++;
                }
                if (tab[i] == 5)
                {
                    
                    licznik5++;
                }


            }

            Console.WriteLine();

            Console.WriteLine($"ilosc 1: {licznik1}, ilosc 2: {licznik2}, ilosc 3: {licznik3}, ilosc 4: {licznik4}, ilosc 5: {licznik5}");


        }
        static void Zadanie3(int [,] tab)
        {
            Random losowa = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j <tab.GetLength(1); j++)
                {
                    tab[i, j] = losowa.Next(1, 10);
                    Console.Write($"{tab[i,j]} ");

                }
                Console.WriteLine();
            }

            int sumaDolnejCzesci = 0;

            for (int i = 1; i < tab.GetLength(0);i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    sumaDolnejCzesci += tab[i, j];
                }
            }

            int sumaGornejCzesci = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    sumaGornejCzesci += tab[i, j];
                }
            }
            Console.WriteLine($"Suma gornej czesci wynosi: {sumaGornejCzesci}, a dolnej {sumaDolnejCzesci}");

            if (sumaDolnejCzesci == sumaGornejCzesci)

            {
                Console.WriteLine("Sa rowne sobie");
            }
            else
            {
                Console.WriteLine("Nie sa sobie rowne");
            }

        }

        static double[,] Zadanie5(double [,] tab, uint nrWiersza, uint nrKolumny)
        {
            if (nrWiersza <=3 && nrWiersza >0)
            {
                for (uint i = nrWiersza-1; i <nrWiersza ; i++)
                {
                    for (int j = 0; j <tab.GetLength(1); j++)
                    {
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Nieprawidlowy numer wiersza lub kolumny");
            }
            return tab;
        }

        static void Main(string[] args)
        {
            Zadanie1(1, 2);
            Console.WriteLine();

            Zadanie2();
            Console.WriteLine();

            int[,] tab = new int[6, 6];
            Zadanie3(tab);
            Console.WriteLine();

            double[,] tablica = new double[3, 3];
            Random losowa = new Random();
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tab[i, j] = losowa.Next(1, 10);
                }
            }

            KontoBankowe nowe = new KontoBankowe("Jan", "Kowalski", 100);


        }
    }
}
