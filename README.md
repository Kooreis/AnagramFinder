# Python Documentation

# Anagram Finder

This Python script is designed to determine if two words entered by the user are anagrams of each other. An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

## Script Description

The script `anagram_finder()` prompts the user to enter two words separated by a space. It then sorts the letters in each word and compares them. If the sorted letters match, the script prints "These words are anagrams." If they do not match, it prints "These words are not anagrams."

Here is a breakdown of the script:

```python
def anagram_finder():
    words = input("Enter two words separated by a space: ").split()
    word1 = sorted(words[0])
    word2 = sorted(words[1])
    if word1 == word2:
        print("These words are anagrams.")
    else:
        print("These words are not anagrams.")
```

- `words = input("Enter two words separated by a space: ").split()`: This line prompts the user to enter two words and splits the input into a list of words.

- `word1 = sorted(words[0])` and `word2 = sorted(words[1])`: These lines sort the letters in each word.

- `if word1 == word2:`: This line compares the sorted letters of the two words. If they match, it means the words are anagrams.

- `print("These words are anagrams.")` and `print("These words are not anagrams.")`: These lines print the result.

## Libraries

This script does not import any libraries. It uses built-in Python functions only.

---

# C# Documentation

# Anagram Finder in C#

This is a simple console application written in C# that finds anagrams of a given word from a list of words.

## Script Description

The script prompts the user to input a word and a list of words (separated by commas). It then checks each word in the list to see if it is an anagram of the input word. If an anagram is found, it is printed to the console.

## Libraries Used

- `System`: This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for basic input/output operations and array manipulation.

- `System.Collections.Generic`: This namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections. In this script, it is used to create and manipulate a list of strings.

- `System.Linq`: This namespace provides classes and interfaces that support queries that use Language-Integrated Query (LINQ). In this script, it is used to convert an array of strings to a list of strings.

## Code Explanation

The script contains three main methods:

- `Main`: This is the entry point of the script. It prompts the user for input, calls the `FindAnagrams` method, and prints the results.

- `FindAnagrams`: This method takes a word and a list of candidate words as input. It checks each candidate word to see if it is an anagram of the input word by calling the `IsAnagram` method. If a candidate word is an anagram, it is added to a list of anagrams, which is returned at the end of the method.

- `IsAnagram`: This method takes two words as input and checks if they are anagrams. It does this by converting each word to a character array, sorting the arrays, and comparing them. If the sorted arrays are equal, the words are anagrams.

---

# Java Documentation

# Anagram Finder in Java

This Java program is designed to determine if two input strings are anagrams of each other. An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once. For example, the word 'cinema' can be rearranged to form the word 'iceman', making them anagrams.

## How it Works

The program prompts the user to input two strings. It then checks if the two strings are anagrams of each other by comparing the sorted arrays of their characters. If the sorted arrays are equal, the strings are anagrams; otherwise, they are not.

## Imported Libraries

The program uses the following Java libraries:

- `java.util.Arrays`: This library provides static methods to manipulate arrays. It is used in this program to sort the arrays of characters and to check if two arrays are equal.

- `java.util.Scanner`: This library is used to read the input provided by the user. It provides methods to parse primitive types and strings using regular expressions, which can be used to break the input into tokens.

## Code Explanation

The `main` method of the `AnagramFinder` class prompts the user to enter two strings. It then calls the `isAnagram` method, passing the two strings as arguments. If `isAnagram` returns `true`, it prints a message stating that the strings are anagrams; otherwise, it prints a message stating that they are not.

The `isAnagram` method first checks if the lengths of the two strings are equal. If they are not, it immediately returns `false`, as two strings cannot be anagrams if they have different lengths. It then converts the strings to arrays of characters, sorts these arrays, and checks if they are equal. If they are, it returns `true`; otherwise, it returns `false`.

---
