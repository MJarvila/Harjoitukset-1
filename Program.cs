/// TEHTÄVÄ 1
///Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme).
///Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

namespace Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number (1, 2 or 3) > ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
                Console.WriteLine("One " + number);
            if (number == 2)
                Console.WriteLine("Two " + number);
            if (number == 3)
                Console.WriteLine("Three " + number);
            if (number > 3)
                Console.WriteLine("Number is larger than 3");
        }
    }
}
/// TEHTÄVÄ 2
/// Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan(pistemäärä kysytään ja ohjelma tulostaa numeron):
/// pisteraja numero
/// 0-1 	0
/// 2-3 	1
/// 4-5 	2
/// 6-7 	3
/// 8-9 	4
/// 10-12 	5
namespace Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give point limit > ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
                Console.WriteLine("Your grade is 0");
            if (number == 2 || number == 3)
                Console.WriteLine("Your grade is 1");
            if (number == 4 || number == 5)
                Console.WriteLine("Your grade is 2");
            if (number == 6 || number == 7)
                Console.WriteLine("Your grade is 3");
            if (number == 8 || number == 9)
                Console.WriteLine("Your grade is 4");
            if (number > 10)
                Console.WriteLine("Your grade is 5");


        }
    }
}
/// TEHTÄVÄ 3
/// Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon
namespace Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter three numbers");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int yhteensa = number1 + number2 + number3;
            Console.WriteLine("Total " + yhteensa);
            int keskiarvo = yhteensa / 3;
            Console.WriteLine("Avg " + keskiarvo);

        }
    }
}

/// TEHTÄVÄ 4
///Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
///jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". 

namespace Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("Underage");
            if (age >= 18 && age < 65)
                Console.WriteLine("Adult");
            if (age >= 65)
                Console.WriteLine("Senior");
            if (age >= 200)
                Console.WriteLine("Jesus Christ.");
        }
    }
}
/// TEHTÄVÄ 5
///Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. 
///Aikamääre sekuntteina kysytään käyttäjältä.
namespace Harjoitukset
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give a time in seconds");
            int secs = int.Parse(Console.ReadLine());
            TimeSpan time = TimeSpan.FromSeconds(secs);
            int hour = time.Hours;
            int min = time.Minutes;
            int sec = time.Seconds;
            //string str = time.ToString(@"hh\:mm\:ss");
            Console.WriteLine("Seconds can be shown as: " + hour + " hours " + min + " minutes " + sec + " seconds ");
        }
    }
}
/// TEHTÄVÄ 6
///Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
///Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
namespace Harjoitukset
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give a distance in kilometers");
            int distance = int.Parse(Console.ReadLine());
            double consumption = distance * 7.02;
            double cost = distance * 1.595;
            Console.WriteLine("The trip uses " + consumption + " liters of gasoline, which will cost " + cost + " monetary units");
        }
    }
}
/// TEHTÄVÄ 7
/// Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
/// Algoritmi:
/// 4:llä jaolliset on, paitsi täydet vuosisadat.Kuitenkin 400:lla jaolliset vuosisadat ovat
/// Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
namespace Harjoitukset
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a year");
            int year = int.Parse(Console.ReadLine());
                if (DateTime.IsLeapYear(year))
                Console.WriteLine(year + " is a leap year.");
                else
                Console.WriteLine(year + " is not a leap year.");
        }
    }
}
/// TEHTÄVÄ 8
/// Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
namespace Harjoitukset
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter three integers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", num3);
            }
        }
    }
}
/// TEHTÄVÄ 9
/// Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
namespace Harjoitukset
{
    class Program
    {
        static void Main()
        {
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                Console.WriteLine("Please give me a number");
                num = int.Parse(Console.ReadLine());
                sum = num + sum;
            }
            Console.WriteLine(sum);
        }
    }
} */
/// TEHTÄVÄ 10
/// Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
/// Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
namespace Harjoitus
{
    class Program
    {
        static void Main()
        {
            int[] nmbrs = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            IEnumerable<int> nmbrQuery =
                from nmbr in nmbrs
                where nmbr % 2 == 0
                select nmbr;
            foreach (int i in nmbrQuery)
            {
                Console.WriteLine(i + " HEP ");
            }
        }
    }
}