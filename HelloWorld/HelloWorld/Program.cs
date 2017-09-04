/*
 * Vernon Tremont Jenkins
 * tremont.jenkins@gmail.com
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string CollectionType;
            string ElementType;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Would you like to make an array or a list?");
            var userResponse = Console.ReadLine();

            switch (userResponse)
            {
                case "List" : 
                    CollectionType = "List";
                    break;
                
                case "Array" : 
                    CollectionType = "Array";
                    break;
                
                default:
                    CollectionType = "Blank";
                    break;
            } 

            Console.WriteLine("Lets create a "+CollectionType +"!");
            Console.WriteLine("What do you want in the " + CollectionType + "?");

            ElementType = Console.ReadLine();

            Console.WriteLine("You chose: "+ElementType);
            Console.WriteLine("How many "+ElementType+"(s) do you want in the " + CollectionType + "?");

            var userInput = Console.ReadLine();
            var Count = Int32.Parse(userInput);

            if (CollectionType == "List")
            {
                MakeAList makeAList = new MakeAList(ElementType, Count);
            }
            else if (CollectionType == "Array")
            {
                MakeAnArray anArray = new MakeAnArray(ElementType, Count);
            }
            else
            {
                throw new Exception("Error: No Collection created, check switch statement");
            }


        }

    }
}
