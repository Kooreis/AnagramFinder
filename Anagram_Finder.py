def anagram_finder():
    words = input("Enter two words separated by a space: ").split()
    word1 = sorted(words[0])
    word2 = sorted(words[1])
    if word1 == word2:
        print("These words are anagrams.")
    else:
        print("These words are not anagrams.")

anagram_finder()