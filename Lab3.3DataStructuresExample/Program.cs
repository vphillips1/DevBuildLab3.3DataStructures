using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab3._3DataStructuresExample
{
    class Program
    {

        static void Main(string[] args)
        {
         
            Console.WriteLine("Please enter some text you would like to reverse:");
            string text = Console.ReadLine();

            ReverseInput(text);
           
        }

        static string ReverseInput(string text)
        {
            Regex validate = new Regex(@"^([a-zA-Z]||\s)+$");

            Stack<char> mystack = new Stack<char>();
            char[] letters = text.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
        
                mystack.Push(letters[i]);
            }         
                 
            if (validate.IsMatch(text))
            {
                Console.Write("Your text you entered in reverse is:");
                string newstring = "";

                for (int i = 0; i < letters.Length; i++)
                {

                    char next = mystack.Pop();
                    // newstring = newstring + next;
                    newstring += next;
                    // Console.Write(next);
                }

                Console.WriteLine(newstring);

                                  
            }
            else
            {
               Console.WriteLine("Please only enter words and not symbols or numbers.");
                   
            }                      
            return text;
        }

        //function called split. If you want to figure out the extended exercises.

       
    }
}
