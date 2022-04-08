using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
           


            SortedList<int, string> pldatename = new SortedList<int, string>();
            pldatename.Add(2001, "C#");
            pldatename.Add(1991, "Python");
            pldatename.Add(1995, "Java");
            pldatename.Add(1985, "C++");
            Console.WriteLine("Sorted list by dates:");
            foreach (var item in pldatename)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }

            SortedList<string,int> plnamedate = new SortedList< string,int>();
            plnamedate.Add("C#", 2001);
            plnamedate.Add("Python", 1991);
            plnamedate.Add("Java", 1995);
            plnamedate.Add("C++", 1985);
            
            Console.WriteLine("Sorted list by names:");

            foreach (var item in plnamedate)
            {
                
                Console.WriteLine("{0} and {1}", item.Key,item.Value);
            }
        }
    }
}

