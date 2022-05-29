using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays8523
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Çağıl";
            string student2 = "Leo";
            string student3 = "Angel";

            string[] students = new string[4];
            students[0] = "Çağıl";
            students[1] = "Leo";
            students[2] = "Angel";
            students[3] = "Muhittin";

            int[] numbers = new[]
            {
                1,2,3,4
            };
            decimal[] decimals = new decimal[] { 1.1m, 2.2m };
            char[] characters = { 'A', 'b', 'i' };

            Console.WriteLine(students[0]);

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            #region Multi Dimensional Arrays: Çok Boyutlu Diziler

            string[,] bolgelerveSehirler = new string[3, 2];
            bolgelerveSehirler[0, 0] = "Marmara";
            bolgelerveSehirler[0, 1] = "İstanbul";
            bolgelerveSehirler[1, 0] = "İç Anadolu";
            bolgelerveSehirler[1, 1] = "Ankara";
            bolgelerveSehirler[2, 0] = "Akdeniz";
            bolgelerveSehirler[2, 1] = "Adana";

            bolgeSehirYazdir(bolgelerveSehirler);
            bolgelerveSehirler = new string[2, 3]
            {
                {"Marmara", "İç Anadolu", "Akdeniz" },
                { "istanbul", "Ankara", "Adana" }
            };
            bolgeSehirYazdir(bolgelerveSehirler);
            #endregion

            Console.ReadLine();
        }

        static void bolgeSehirYazdir(string[,] bolgelerveSehirler)
        {
            for (int satir = 0; satir <= bolgelerveSehirler.GetUpperBound(0); satir++)
            {
                for (int sutun = 0; sutun <= bolgelerveSehirler.GetUpperBound(1); sutun++)
                {
                    Console.Write(bolgelerveSehirler[satir, sutun] + "  ");
                }
                Console.Write("\n");
            }
        }
    }
}
