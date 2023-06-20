```CSharp
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

        List<string> anagrams = FindAnagrams(word, wordList);

        Console.WriteLine("Anagrams found:");
        foreach (string anagram in anagrams)
        {
            Console.WriteLine(anagram);
        }
    }

    static List<string> FindAnagrams(string word, List<string> candidates)
    {
        List<string> anagrams = new List<string>();
        foreach (string candidate in candidates)
        {
            if (IsAnagram(word, candidate))
            {
                anagrams.Add(candidate);
            }
        }
        return anagrams;
    }

    static bool IsAnagram(string word, string candidate)
    {
        char[] wordArray = word.ToLower().ToCharArray();
        char[] candidateArray = candidate.ToLower().ToCharArray();
        Array.Sort(wordArray);
        Array.Sort(candidateArray);
        return new string(wordArray) == new string(candidateArray);
    }
}
```