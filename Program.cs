using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Question 1"); //Console Title.
            Console.WriteLine("Hassan"); //Author Name.
            Console.WriteLine("\nWrite a static method that, given a sentence, returns the number"); //Question
            Console.WriteLine("of times that each letter of the alphabet occurs in the sentence."); //Question Continued...

            Console.WriteLine("\nPress 1 and enter to Start"); //Menu option to start the application
            Console.WriteLine("Press 2 and enter to Exit"); //Menu option to exit the application
            Console.Write("\nOption: "); //Enter one of the menu options.

            int option = 0; //Option declared as an integer which is equal to 0.

            while (true) //loops program to menu again and user can start over
            {
                do
                {
                    option = Convert.ToInt32(Console.ReadLine()); //Number selection for the menu.

                    switch (option)
                    {
                        case 1:
                            if (option == 1)
                            {
                                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //String of letters.
                                Console.Write("\nPlease enter a word/sentence: "); //user enters a string of their choice here.

                                string sentence = Console.ReadLine().ToUpper(); //Counts lower and uppercase letter as the same. Example 'a and A' counted as the same and so on.

                                Dictionary<string, int> character = new Dictionary<string, int>(); //dictionary used to declare the string.

                                //Add every letter (declared in the string) to the Dictionary. Value set to 0.
                                for (int i = 0; i < letters.Length; i++)
                                {
                                    character.Add(letters.Substring(i, 1), 0);
                                }

                                //if the string contains a key declared in the string, it will be added to display in the output.
                                foreach (char input in sentence)
                                {
                                    if (character.ContainsKey(input.ToString()))
                                    {
                                        character[input.ToString()] = character[input.ToString()] + 1;
                                    }
                                }

                                List<string> list = character.Keys.ToList(); //Adds the string into a list.
                                list.Sort(); //sorts the list in alphabetical order.

                                //Print the frequency for every letter, regardless of whether it is in sentence or not.
                                foreach (string key in list)
                                {
                                    //Text to display the table for count of letters.
                                    Console.WriteLine(" --------------------------------------------");
                                    Console.WriteLine("|     LETTER     |   NUMBER OF TIMES USED    |");
                                    Console.WriteLine("|--------------------------------------------|");
                                    Console.WriteLine("|       {0}        |           {1}               |", key, character[key]);
                                    Console.WriteLine(" --------------------------------------------");
                                }
                                Console.WriteLine("\nPress 1 and enter to Start"); //Menu option to start the application
                                Console.WriteLine("Press 2 and enter to Exit"); //Menu option to exit the application
                                Console.Write("\nOption: "); //enter one of the menu options.
                            }
                            break;

                        case 2:
                            if (option == 2) //if 2 is selected as an option.
                            {
                                Environment.Exit(0); //program will exit.
                            }
                            break;

                        default:

                            //if user enters a value greater than 2, error message will appear until user enters correct value within the range.
                            Console.Write("Error. Please enter the correct menu option: ");
                            break;
                    }
                }
                while (option > 2); //error message appears if user input for menu selection is greater than 2.
            }
        }
    }
}
