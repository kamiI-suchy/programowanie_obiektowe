using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double liczba;
            Console.WriteLine("Podaj liczbę z której zostanie oblicz");
            liczba = float.Parse(Console.ReadLine());
            Console.Clear();
            while (liczba >= 0)
            {
                Console.WriteLine("Pierwiastek liczby {0} wynosi: {1}", liczba, Math.Sqrt(liczba));
                Console.WriteLine("Podaj liczbę");
                liczba = float.Parse(Console.ReadLine());
                Console.Clear();
            }
            int suma = 0;
            for (int i  = 0; i < 1001; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma wszystkich liczb nieparzystych od 1 do 1000 wynosi {0}", suma);
            Console.ReadKey();
            Console.WriteLine("Podaj liczbę n, do której należy wypisać liczby naturalne kończące się na 2, 5 oraz 7");
            int n = int.Parse(Console.ReadLine());
            string liczba = "";
            for (int i = 0; i <= n; i++)
            {
                liczba = Convert.ToString(i);
                if (liczba.EndsWith("2") || liczba.EndsWith("5") || liczba.EndsWith("7"))
                {
                    Console.WriteLine(liczba);
                }
                
            }
            Console.ReadKey();
            bool IsPrime(int n)
            {
                if (n <= 1)
                {
                    return false;
          
                }

                if (n <= 3) 
                {
                    return true;
                }

                if (n % 2 == 0 || n % 3 == 0)
                {
                    return false;
                }

                for (int i =5; i * i < n; i++)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;

            }
            Console.WriteLine("Podaj liczbę do sprawdzenia:");
            int liczba = int.Parse(Console.ReadLine());
            Console.Clear();
            if (IsPrime(liczba))
            {
                Console.WriteLine("{0} jest liczbą pierwszą.", liczba);
            }
            else
            {
                Console.WriteLine("{0} nie jest liczbą pierwszą.", liczba);
            }
            Console.ReadKey();
            Console.WriteLine("Podaj liczbę do sprawdzenia palindromu:");
            string liczba = Console.ReadLine();

            string liczba2 = new string(liczba.Reverse().ToArray());

            if (liczba == liczba2)
            {
                Console.WriteLine("Liczba {0} jest palindromem.", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest palindromem.", liczba);
            }

            Console.ReadKey();

            Console.WriteLine("Podaj liczbę z której trzeba obliczyć silnię:");
            int liczba = int.Parse(Console.ReadLine());
            Console.Clear();
            int suma = 1;
            for (int i = liczba; i > 0; i--)
            {
                suma = suma * i;
            }
            Console.WriteLine("Silnia liczby {0} wynosi {1}", liczba, suma);
            Console.ReadKey();
            double suma = 0.0;
            double dol = 1.0;
            for (int i = 0; i <= 100; i++)
            {
                for (int n = i; n > 0; n--)
                {
                    dol = dol * n;
                }

                suma = suma + (1.0 / dol);
                dol = 1.0;
            }
            Console.WriteLine("Liczba e w przybliżeniu wynosi {0}", suma);
            Console.ReadKey();
            int d = 0;
            for (int i = 0; i <= 1000;  i++)
            {
                if (i % 7 == 0)
                {
                    d += i;
                }
            }
            Console.WriteLine(d);
            Console.ReadKey();
            Console.WriteLine("Podaj swoje imię.");
            string imie = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj swój wiek.");
            int wiek = int.Parse(Console.ReadLine());
            Console.Clear();

            if (wiek >= 18)
            {
                Console.WriteLine("witaj {0}, masz {1} lat", imie, wiek);
                Console.WriteLine("Dostęp przyznany");
            } 
            else
            {
                Console.WriteLine("witaj {0}, masz {1} lat", imie, wiek);
                Console.WriteLine("Dostęp nie przyznany");
            }
            Console.ReadKey();
            Console.WriteLine("Podaj znak operacji: + - dodawanie, - - odejmowanie, * - mnożenie, / - dzielenie");
            string operacja = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (operacja)
            {
                case "+":
                    Console.WriteLine("Wynik dodawania liczb {0} i {1} wynosi {2}", liczba1, liczba2, liczba1 + liczba2);
                    break;
                case "-":
                    Console.WriteLine("Wynik odejmowania liczb {0} i {1} wynosi {2}", liczba1, liczba2, liczba1 - liczba2);
                    break;
                case "*":
                    Console.WriteLine("Wynik mnożenia liczb {0} i {1} wynosi {2}", liczba1, liczba2, liczba1 * liczba2);
                    break;
                case "/":
                    if (liczba2 != 0)
                    {
                        Console.WriteLine("Wynik dzielenia liczb {0} i {1} wynosi {2}", liczba1, liczba2, liczba1 / liczba2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nie da się dzielić przez 0");
                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();*/

        }
    }
}
