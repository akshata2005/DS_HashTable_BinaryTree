﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        private const string V = " ";

        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to hash table implementation program...\n");
            Console.WriteLine(" --> Finding frequency of words ");

            string inputText = "to be or not to be";
            string[] inputWords = inputText.Split();
            Console.WriteLine(" Input Sentence : " + inputText);
            int count = 0;

            MyMapyNode<string, string> node = new MyMapyNode<string, string>(6);

            foreach (var text in inputWords)
            {
                node.Add(count.ToString(), text);
                count++;
            }

            int numOfTo = node.GetFrequencyOfWords("to");
            Console.WriteLine(" Frequency of to  : " + numOfTo);
            int numOfbe = node.GetFrequencyOfWords("be");
            Console.WriteLine(" Frequency of be  : " + numOfbe);
            int numOfor = node.GetFrequencyOfWords("or");
            Console.WriteLine(" Frequency of or  : " + numOfor);
            int numOfnot = node.GetFrequencyOfWords("not");
            Console.WriteLine(" Frequency of not  : " + numOfnot);
        }
    }
}
