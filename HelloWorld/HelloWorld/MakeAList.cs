/*
 * Vernon Tremont Jenkins
 * tremont.jenkins@gmail.com
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
	/// <summary>
	/// Make list. Contains a constructor that takes two arg:
	/// string element. type of element the list will contain.
	/// int count. initial amount of the list.
	/// Adds/initializes the count amount of elements to a list.
	/// </summary>
	public class MakeAList
	{
		//Fields
		private string elementType;
		private int listCount;
        private List<object> list;

		//Properties
		public string ElementType { get { return elementType; } set { elementType = value; } }
		public int ListCount { get { return listCount; } set { listCount = value; } }
        public List<object> TheList { get { return list; }set { list = value; }}

		//Constructor (ctor)
		public MakeAList(string element, int count)
		{
			this.ElementType = element;
			this.ListCount = count;
			TheList = new List<object>(listCount);
			Create();
		}

		//Method to create list
		private void Create()
		{
			for (int i = 0; i < listCount; i++)
			{
				TheList.Add(elementType + " " + (i + 1));
				Console.WriteLine(elementType + " " + (i + 1) + " added to the list.");
			}

			Console.WriteLine("List created.");
		}
	}
}
