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

        public void TESTModule()
        {
            int x = 1;
            //float[] floatNum = { 1.0f, 2.0f };
            float firstNum = 1.0f;
            float secondNum = 2.0f;
            string typeValue = "";
            string whatWasTyped = Console.ReadLine(); 
            switch (x)
            {
                case 1:
                    for (int i = 1; i < 5; i++)
                    {
                        int r = i * 2;
                        Console.WriteLine(r);
                    }
                    break;
                case 2:
                    for (int i = 1; i > 5; i++)
                    {
                        int r = i * 3;
                        Console.WriteLine(r);
                    }
                    break;
                case 3:
                    for (int i = 1; i < 1; i++)
                    {
                        Console.WriteLine("Sorry, enter a number that is greater than one.");
                    }
                    break;
                case 4:                   
                    if (firstNum == 1.0 && secondNum == 2.0)
                    {
                        Console.WriteLine("3.0f");
                    }
                    break;
                case 5:
                    string upperstr = typeValue.ToUpper();

                    Console.WriteLine(upperstr);
                    break;
                default:
                    Console.WriteLine("You just typed: " + whatWasTyped + " to the screen.");
                    break;
            }
        }
    }
}
