using System;
using System.Collections;

namespace ProgramingLanguageYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consol penceresinde outputlar coxdur ustede nezer salarsiz sertde istenen;ere gore 
            SortedList PLanguage = new SortedList();

            PLanguage.Add(2010, "Rust");
            PLanguage.Add(1964, "BASIC");
            PLanguage.Add(2014, "Swift");
            PLanguage.Add(1972, "C");
            PLanguage.Add(1951, "Regional Assembly Language");
            PLanguage.Add(1969, "B");
            PLanguage.Add(1995, "Java");
            PLanguage.Add(1984, "Objective-C");
            PLanguage.Add(1986, "MATLAB");
            PLanguage.Add(2005, "F#");
            PLanguage.Add(1991, "Visual Basic");
            PLanguage.Add(1994, "Ruby");
            PLanguage.Add(2001, "C#");
            PLanguage.Add(1970, "Pascal");
            PLanguage.Add(2009, "Go");
            PLanguage.Add(1990, "Python");
            PLanguage.Add(1980, "C++");
            Console.WriteLine("Illere Gore:");
            foreach (DictionaryEntry item in PLanguage)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine("\n--------------------------\n");
            SortedList PLanguage1 = new SortedList();
            PLanguage1.Add("Rust", 2010);
            PLanguage1.Add("BASIC", 1964);
            PLanguage1.Add("Swift", 2014);
            PLanguage1.Add("C", 1972);
            PLanguage1.Add("Regional Assembly Language", 1951);
            PLanguage1.Add("B", 1969);
            PLanguage1.Add("Java", 1995);
            PLanguage1.Add("Objective-C", 1984);
            PLanguage1.Add("MATLAB", 1986);
            PLanguage1.Add("F#", 2005);
            PLanguage1.Add("Visual Basic", 1991);
            PLanguage1.Add("Ruby", 1994);
            PLanguage1.Add("C#", 2001);
            PLanguage1.Add("Pascal", 1970);
            PLanguage1.Add("Go", 2009);
            PLanguage1.Add("Python", 1090);
            PLanguage1.Add("C++", 1980);
            Console.WriteLine("Adlara g]Gore:");
            foreach (DictionaryEntry item in PLanguage1)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

        }
    }
}
