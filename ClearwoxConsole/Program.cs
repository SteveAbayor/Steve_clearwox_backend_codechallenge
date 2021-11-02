using System;
using System.Collections.Generic;

namespace ClearwoxConsole
{
    class Program
    {
        public static class QuestionClass
        {
            static List<string> NameList = new List<string>()
            {
                "Jimmy",
                "Jeffery",
                "John",
            };
        }
        static void Main(string[] args)
        {
            var names = new List<string>();
            do
            {
                Console.WriteLine("Hello, you are welcome");
            } 
            while (names != null);
            
        }
    }
}
