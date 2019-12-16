using System;
using Changer;
using System.Collections.Generic;

namespace MainProgram
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Please type a sentence to be translated.");
            string userInput = Console.ReadLine();
            LeetspeakTranslator translated = new LeetspeakTranslator();
            Console.WriteLine(translated.Translate(userInput));
        }
    }
}