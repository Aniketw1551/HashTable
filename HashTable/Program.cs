﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            string paragraph = "Nory was a Catholic because her mother was a Catholic, and Nory’s mother was a Catholic because her father was a Catholic";
            CountFrequencyofWords(paragraph);
            Console.ReadLine();
        }
        //Count the frequency of the words
        public static void CountFrequencyofWords(string paragraph)
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (myMapNode.Exists(word))
                    myMapNode.Add(word.ToLower(), myMapNode.Get(word) + 1);
                else
                    myMapNode.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Display after add operation");
            myMapNode.Display();
        }
    }
}
