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
		/// <summary>
		/// Make an array. Contains a constructor that takes two arg:
		/// string element. type of element the array will contain.
		/// int count. initial amount of the array.
		/// Adds/initializes the count amount of elements to an array.
		/// </summary>
		public class MakeAnArray
        {

            //Fields
            private object elementType;
            private int arrayCount;
            private object[] anArray;

            //Properties
            public object ElementType { get { return elementType; } set { elementType = value; } }
            public int Count { get { return arrayCount; } set { arrayCount = value; } }
            public object[] AnArray { get { return anArray; } set { anArray = value; } }

            //Constructor (ctor)
            public MakeAnArray(string element, int count)
            {
                this.ElementType = element;
                this.Count = count;
                AnArray = new object[Count];
                Create();
            }

            //Method to create list
            private void Create()
            {
                for (int i = 0; i < AnArray.Length; i++)
                {
                    AnArray[i] = elementType.ToString();
                    Console.WriteLine(AnArray[i] + " " + (i + 1) + " added to the array.");
                }

                Console.WriteLine("Array created.");

            }
        }

    }
}
