using System;

namespace Struktury
{
    class Program
    {
        public struct Student
        {
            public string imie, nazwisko;
            public int nr_indeksu, ocena;
        }
        static void Main(string[] args)
        {
            int srednia=0;
            int suma = 0;
            string buffor;
            int buf = 0;
            string[] liczebniki = new string[5] { "Pierwszego","Drugiego","Trzeciego","Czwartego","Piatego"};
            Student[] tab = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj imie " + liczebniki[i] + " studenta");
                tab[i].imie = Console.ReadLine();

                Console.WriteLine("Podaj nazwisko " + liczebniki[i] + " studenta");
                tab[i].nazwisko = Console.ReadLine();

                Console.WriteLine("Podaj indeks " + liczebniki[i] + " studenta");
                tab[i].nr_indeksu = Console.Read();
                buffor = Console.ReadLine();
                buf = int.Parse(buffor);

                Console.WriteLine("Podaj ocene " + liczebniki[i] + " studenta");
                buffor=Console.ReadLine();
                buf = int.Parse(buffor);
                tab[i].ocena = buf;
             
                
            }
            
            
            suma = tab[0].ocena + tab[1].ocena + tab[2].ocena + tab[3].ocena + tab[4].ocena;
            srednia = suma / 5;

            Console.WriteLine("Srednia: " + srednia);

            for (int u = 0; u < 5; u++)
            {
                if (tab[u].ocena > srednia)
                    Console.WriteLine("Oceny powyzej sredniej: " + tab[u].ocena);
            }
            Console.WriteLine("");
            for (int z = 0; z < 5; z++)
            {
                if (tab[z].ocena < srednia)
                    Console.WriteLine("Oceny ponizej sredniej: " + tab[z].ocena);
            }
            Console.ReadLine();
        }
    }
}
