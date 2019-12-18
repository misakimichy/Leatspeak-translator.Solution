using System;
using Changer;

namespace MainProgram
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("We are going to tranlate a sentence to leet.");
            CheckUserInput();
        }

        private static void CheckUserInput()
        {
            Console.WriteLine("Please type a sentence to be translated.");
            string userInput = Console.ReadLine();
            int inputCheck;
            bool result = Int32.TryParse(userInput, out inputCheck);
            if(!result)
            {
                LeetspeakTranslator translated = new LeetspeakTranslator();
                Console.WriteLine(translated.Translate(userInput));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please enter a sentence!");
                Console.ResetColor();
                CheckUserInput();
            }
        }
    }
}