using System;
using System.Text.RegularExpressions;

namespace WS6_6_Smileys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ReadText();
            text = ReplaceSmileys(text, "*");
            Console.WriteLine(text);
        }
        // 1.	ReadText(): Asks the user for a string and stores it in a variable.
        static string ReadText()
        {
            Console.WriteLine("Please enter text: ");
            return Console.ReadLine();
        }
        // 2.	ReplaceSmileys(string text) : Finds smileys in text and replaces them with spaces.
        static string ReplaceSmileys(string text)
        {
            // Replacement done simply using Replace() method in String class.
            return text.Replace(":)", " ");
        }
        // 3.	ReplaceSmileys(string text, string replacer): Finds smileys in text and replaces them with replacer.
        static string ReplaceSmileys(string text, string replacer)
        {
            // Replacement done using a regular expression
            string smileys= @"\:\)|:-\)|:\(|:-\(|;\); -\)|:-O | 8 -|:P |:D |:\||:S |:\$|:@| 8o\||\+o\(|\(H\)|\(C\)|\(\?\)";
            return Regex.Replace(text, smileys, replacer);
        }
    }
    
}
