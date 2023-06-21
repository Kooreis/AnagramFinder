using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        Console.WriteLine("Enter a list of words (separated by comma):");
        string words = Console.ReadLine();
        List<string> wordList = words.Split(',').ToList();
    }