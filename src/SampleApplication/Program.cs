using System;
using System.IO;
using Model;

namespace SampleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\codebase\CodeTest\src\testFile.txt";
            var fileString = new SimpleFileReader(new StreamReader(filePath)).ReadFromFile();

            var uniqueWordsCounter = new IndividualWordCounter(fileString);
            uniqueWordsCounter.CountUniqueWords();
            
            Console.WriteLine("Key - Count - IsPrime");
            foreach (var i in uniqueWordsCounter.IndividualWordsAndFrequency)
            {
               Console.WriteLine("{0} - {1} - {2}",i.Key,i.Value, PrimeNumberFinder.IsNumberPrime(i.Value));
            }
            Console.WriteLine("Key - Count - IsPrime");
            Console.WriteLine("******************************");
            Console.WriteLine("Total Individual Words From the given file was - "+ uniqueWordsCounter.WordCount.ToString());

            Console.ReadLine();
        }

       
    }
}
