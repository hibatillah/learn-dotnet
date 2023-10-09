using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Hibatillah_3SIC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ========== Hello World ========== */
            /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            */

            /* ========== Input ========== */
            /*
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");

            String FirstName;
            FirstName = Console.ReadLine();

            String LastName;
            Console.Write("Type your last name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello " + FirstName + " " + LastName);
            Console.ReadLine();
            */

            /* ========== Biodata ========== */
            /*
            Console.WriteLine("BIODATA");

            Console.Write("Name: ");
            String Name = Console.ReadLine();

            Console.Write("Umur: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Prodi: ");
            String Major = Console.ReadLine();

            Console.Write("No. Hape: ");
            int NumberPhone = int.Parse(Console.ReadLine());

            Console.Write("Alasan masuk PCR: ");
            String Reason = Console.ReadLine();

            Console.WriteLine("\nHalo saya " + Name +
                "\nUmur " + Age + " tahun" +
                "\nProdi " + Major +
                "\nNo Hape " + NumberPhone +
                "\nAlasan masuk PCR " + Reason);
            Console.ReadLine();
            */

            /* =========== Conditional =========== */
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door : 1, 2, or 3: ");
            string UserValue = Console.ReadLine();
            string Message = " ";

            if (UserValue == "1") 
            {
                Message = "You won a new car";
            } 
            else if (UserValue == "2") 
            {
                Message = "You won a new boat";
            } 
            else if (UserValue == "3") 
            {
                Message = "You won a new cat";
            } 
            else 
            {
                Message = "Sorry we didnt understand ";
                Message = Message + "You Lost";
            }
            Console.WriteLine(Message);
            Console.ReadLine();
            */

            /* =========== Looping =========== */
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            /* =========== Odd & Even =========== */
            Console.Write("Type a number: ");
            int num = int.Parse(Console.ReadLine());
            String desc = "";

            if (num < 0)
            {
                desc = num + " is negative";
            } 
            else
            {
                if (num % 2 == 0)
                {
                    desc = num + "is Even";
                }
                else
                {
                    desc = num + " is Odd";
                }
            }
            Console.WriteLine(desc);
            Console.ReadLine();
        }
    }
}
