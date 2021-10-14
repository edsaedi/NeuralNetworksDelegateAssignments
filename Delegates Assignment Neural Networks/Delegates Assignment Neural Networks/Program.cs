using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_Assignment_Neural_Networks
{
    class Program
    {


        public static List<TResult> Select<TElement, TResult>(List<TElement> input, Func<TElement, TResult> function)
        {
            List<TResult> result = new List<TResult>();
            foreach (TElement interval in input)
            {
                result.Add(function(interval));
            }
            return result;
        }

        public static List<TElement> Where<TElement>(List<TElement> input, Func<TElement, bool> function)
        { 
            List<TElement> result = new List<TElement>();

            foreach (var interval in input)
            {
                if(function(interval))
                {
                    result.Add(interval);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "Bob",
                "FRREED",
                "BIJILL",
                "MarthA"
            };

            //var newWords = words.Select((string word) => word.ToLower());
            //foreach (var newWord in newWords)
            //{
            //    Console.WriteLine($"{newWord}, ");
            //}

            //var newestWords = Select(words, ((string word) => word.ToLower()));

            //Console.WriteLine("Break");

            //foreach (var newestWord in newestWords)
            //{
            //    Console.WriteLine($"{newestWord}, ");
            //}

            var containsB = Where<string>(words, ((string word) => word.Contains('b')));

            words.MyWhere().Select().Where

            var officialContainsB = words.Where<string>(((string word) => word.Contains('b')));
            foreach (var item in containsB)
            {
                Console.WriteLine($"{containsB}, ");
            }
        }
    }

    static class MyExtensions
    {
        public static List<TResult> MyWhere<TElement, TResult>(this List<TElement> list, Func<> selector)
        {
            
        }
    }
}
