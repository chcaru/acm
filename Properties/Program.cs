﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
	{
		public string FirstName { get; set; } 			
		public string LastName { get; set; }
 		public string FullName 
		{		
			get
			{
				return this.FirstName + " " + this.LastName;
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var me = new Person();

	        me.FirstName = "Chris";
	        me.LastName = "Caruso";

	        Console.WriteLine(me.FullName); //Will print out: Chris Caruso

            Console.ReadLine();
        }

    }
}
