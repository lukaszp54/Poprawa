using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumP
{
    class KontoBankowe
    {
        private static double _stan;
        private int _numer;
        private readonly string _imie;
        private readonly string _nazwisko;

        public KontoBankowe(string imie, string nazwisko, double stan)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            Stan = stan;
        }

        public double Stan
        {
            set
            {
                if (value < -100)
                {
                    Console.WriteLine("Za duży debet");
                }
            }
        }

        public static double Uznanie(double uznanie)
        {
            _stan += uznanie;
            return _stan;
        }
        public static double Obciazenie(double obciazenie)
        {
            _stan += obciazenie;
            return _stan;
        }

     

    }
}
