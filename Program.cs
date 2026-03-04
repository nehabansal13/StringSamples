using StringSamples;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Strings stringHelper = new Strings();

// Test RemoveDuplicateChar
Console.WriteLine("=== RemoveDuplicateChar ===");
string input1 = "Hello World";
string result1 = stringHelper.RemoveDuplicateChar(input1);
Console.WriteLine($"Input: {input1}");
Console.WriteLine($"Result: {result1}");
Console.WriteLine();

// Test GetLongestWord
Console.WriteLine("=== GetLongestWord ===");
string input2 = "The quick brown fox jumps over the lazy dog";
string result2 = stringHelper.GetLongestWord(input2);
Console.WriteLine($"Input: {input2}");
Console.WriteLine($"Longest Word: {result2}");
Console.WriteLine();

// Test SortInt
Console.WriteLine("=== SortInt ===");
int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
Console.WriteLine($"Input: [{string.Join(", ", numbers)}]");
int[] sortedNumbers = stringHelper.SortInt(numbers);
Console.WriteLine($"Sorted: [{string.Join(", ", sortedNumbers)}]");
Console.WriteLine();

// Test SortChars
Console.WriteLine("=== SortChars ===");
char[] chars = { 'z', 'a', 'm', 'b', 'x', 'c' };
Console.WriteLine($"Input: [{string.Join(", ", chars)}]");
char[] sortedChars = stringHelper.SortChars(chars);
Console.WriteLine($"Sorted: [{string.Join(", ", sortedChars)}]");
Console.WriteLine();

// Test IsAnagram
Console.WriteLine("=== IsAnagram ===");
string word1 = "listen";
string word2 = "silent";
bool isAnagram1 = stringHelper.IsAnagram(word1, word2);
Console.WriteLine($"'{word1}' and '{word2}' are anagrams: {isAnagram1}");

string word3 = "hello";
string word4 = "world";
bool isAnagram2 = stringHelper.IsAnagram(word3, word4);
Console.WriteLine($"'{word3}' and '{word4}' are anagrams: {isAnagram2}");
Console.WriteLine();