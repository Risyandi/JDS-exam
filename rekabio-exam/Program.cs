using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPraktekRekabio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soal Nomor 1
            string alphabet = "PT.REKABIO";
            string lowerAlphabet = alphabet.ToLower();
            Console.WriteLine("---------------");
            Console.WriteLine(lowerAlphabet);
            Console.WriteLine("---------------");

            // Soal Nomor 2
            string tanggal = "18 Februari 2020";
            DateTime dateTimeConvert = Convert.ToDateTime(tanggal);
            Console.WriteLine(dateTimeConvert.ToString("MM/dd/yyyy"));
            Console.WriteLine(dateTimeConvert.ToString("yyyy-MM-dd"));
            Console.WriteLine(dateTimeConvert.ToString("M/dd/yyyy"));
            Console.WriteLine("---------------");

            // Soal Nomor 3
            string namaPT = "Rekabio Makin Jaya";
            string newNamaPT = "Makin Jaya Rekabio";
            namaPT = newNamaPT;
            Console.WriteLine(namaPT);

            // Soal Nomor 4
            Console.WriteLine("---------------");
            Console.Write("Enter Num 1 = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Operator = ");
            string op = Console.ReadLine();

            Console.Write("Enter Num 2 = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------");

            if (op == "+"){
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            Console.WriteLine("---------------");

            // Soal Nomor 5
            List<string> myCollection = new List<string> { "Ari", "jajang", "Roby" };
            myCollection.Add("Risyandi");
            Console.WriteLine(myCollection);
            Console.WriteLine("---------------");Generic


        }
    }
}
