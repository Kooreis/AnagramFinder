List<string> anagrams = FindAnagrams(word, wordList);

        Console.WriteLine("Anagrams found:");
        foreach (string anagram in anagrams)
        {
            Console.WriteLine(anagram);
        }