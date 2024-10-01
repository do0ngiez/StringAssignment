using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Yujin";
            string lName = "Ahn";
            string greeting = "Welcome, ";

            //concat
            string sentence = greeting + fName + " " + lName + "!";
            Console.WriteLine(sentence);

            //convert to uppercase
            string lowerCase = "this will turn into uppercase.";
            string upperCase = lowerCase.ToUpper(); 
            Console.WriteLine(upperCase);

            //stringbuilder
            StringBuilder paragraph = new StringBuilder();

            //append to string builder
            paragraph.Append("First sentence here. ");
            paragraph.Append("Then, second sentence. ");
            paragraph.Append("Lastly, third sentence.");

            Console.WriteLine(paragraph.ToString());
            Console.ReadLine();
        }
    }
}
