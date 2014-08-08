using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApp
{
    class Program
    {
        public static int appendix(int numer)
        {
            // np. godzina - 1, godziny - 2, godzin - 3
            if (numer == 1) return 1;
            else if (numer % 10 >= 2 && numer % 10 <= 4) return 2;
            else return 3;
        }
        public static int pobierzLiczbe(string message) {
            int liczba = 0;
            Console.WriteLine(message);
            bool noerror = true;
            do
            {
                try
                {
                    liczba = Convert.ToInt32(Console.ReadLine());
                    noerror = true;
                }
                catch (FormatException e)
                {
                    noerror = false;
                    Console.WriteLine(e.Message);
                }
            } while (noerror == false);
            return liczba;
        }
        public static void Main()
        {
            //System.Windows.Forms.Form f = new MyFirstApp.Form1();
            //f.Show();
            DateTime currentDate = DateTime.Now;
            
            int? year = null, month = null, day = null; //typ NULLABLE
            month = pobierzLiczbe("Podaj miesiac: ");
            day = pobierzLiczbe("Podaj dzien: ");

            DateTime FinalnaData = new DateTime(year??2014, month??7, day??12);//trzeba podać co dzieje się w przypadku wartości null
            Console.WriteLine("dzień wyjazdu : {0}", FinalnaData);
            Console.WriteLine("aktualna data : {0}",currentDate);

            string hours_s, minutes_s;
            int daysdiff = (FinalnaData - currentDate).Days, hoursdiff = (FinalnaData - currentDate).Hours, minutesdiff = (FinalnaData - currentDate).Minutes;

            int h_a = appendix((FinalnaData - currentDate).Hours), m_a = appendix((FinalnaData - currentDate).Minutes);
            if (h_a == 1) hours_s = "godzina";
                else if (h_a == 2) hours_s = "godziny";
                else hours_s = "godzin";
            if (m_a == 1) minutes_s = "minuta";
                else if (m_a == 2) minutes_s = "minuty";
                else minutes_s = "minut";

            Console.WriteLine("zostalo {0} {1}, {2} {3} i {4} {5} do Naszych wspaniałych wspólnych chwil! :D ", 
                daysdiff, (daysdiff == 1)?"dzień":"dni", hoursdiff, hours_s , minutesdiff, minutes_s);
            


            Console.ReadLine();
        }
        
    }
}
