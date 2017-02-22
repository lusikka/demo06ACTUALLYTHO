using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = "0";
            string line = "0";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");
            Console.WriteLine("Time to text. Give me lines! End with a zero.");
            do
            {
                line = Console.ReadLine();
                outputFile.WriteLine(line);               
            } while (!line.Equals(end));
            outputFile.Close();
            try
            {
                string text = System.IO.File.ReadAllText("test.txt");
                Console.WriteLine("Contents of test.txt:");
                Console.WriteLine(text);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
