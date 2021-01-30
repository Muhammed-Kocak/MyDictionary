using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary2<int, string> myDictionary2 = new MyDictionary2<int, string>();
            myDictionary2.Add(1, "Hello");
            myDictionary2.Add(2, "Word");
            Console.WriteLine(myDictionary2.Keys[0]+" : " + myDictionary2.Values[0]);
            Console.WriteLine(myDictionary2.Keys[1]+" : " + myDictionary2.Values[1]);

            MyDictionary2<string, string> myDictionary3 = new MyDictionary2<string, string>();
            myDictionary3.Add("Meyve", "Elma");
            myDictionary3.Add("Sebze", "Ispanak");
            Console.WriteLine(myDictionary3.Keys[0] + " : " + myDictionary3.Values[0]);
            Console.WriteLine(myDictionary3.Keys[1] + " : " + myDictionary3.Values[1]);

        }
    }
}
