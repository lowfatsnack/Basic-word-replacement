using System;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int option;
            int check = 1;
            Boolean loop = true;

            //will continue to loop if check = 1
            while (check == 1)
            {
                option = OptionCheck();
                if (option == 1)
                {
                    Option1();
                }
                else if (option == 2)
                {
                    Option2();
                }



                Console.WriteLine("Enter 1 to select a new option, Enter any other number to end");
                input = Console.ReadLine();
                check = NumberCheck(input);

            }//end of while
        }

        private static int OptionCheck()
        {
            Boolean loop = true;
            String input;
            int value = 0;
            while (loop == true)
            {
                Console.WriteLine("Enter 1 to find a pattern, Enter 2 to replace a word or a set of words");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out int number))
                {
                    if (number == 1 | number == 2)
                    {
                        value = number;
                        loop = false;
                    }
                    else
                    {
                        loop = true;
                    }
                }//end of number check (converts from String to Int)

            }//wiil continue to loop until a correct input has been entered

            return value;

        }//end of OptionCheck

        private static int NumberCheck(String input)
        {
            int value = 0;
            Boolean isNumber = false;
            while (isNumber == false)
            {
                if (Int32.TryParse(input, out int number))
                {
                    value = number;
                    isNumber = true;
                }//end of number check (converts from String to Int)
                else
                {
                    Console.WriteLine("Enter a number");
                    input = Console.ReadLine();
                }
            }
            return value;
        }

        private static void Option1()
        {
            String input;
            String pattern = "tonight";

            Console.WriteLine("Enter a word to find, to use the default value just press enter");
            input = Console.ReadLine();
            if (input == "")
            {

            }
            else
            {
                pattern = input;
            }

            Console.WriteLine("Enter a phrase and I will check if it contains the phrase \"" + pattern + "\" ");
            input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            if (matches.Count == 0)
            {
                Console.WriteLine("The entered phrase doesn't contain \"" + pattern + "\"");
            }
            else
            {
                Console.WriteLine("# of times \"" + pattern + "\" is used : " + matches.Count);
            }
        }//end of option1

        private static void Option2()
        {
            String input = "placeholder";
            String pattern = "placeholder";
            String phrase;

            Console.WriteLine("Enter the word you would like to replace");
            input = Console.ReadLine();
            pattern = input;

            Console.WriteLine("Enter what you would want to replace \"" + pattern + "\" with");
            input = Console.ReadLine();

            Console.WriteLine("Enter a phrase and I will check if it contains the phrase \"" + pattern + "\" and it will be replaced with \"" + input + "\"");
            phrase = Console.ReadLine();
            phrase = Regex.Replace(phrase, pattern, input, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            Console.WriteLine(phrase);

        }
    }
}

