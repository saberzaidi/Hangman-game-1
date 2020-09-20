using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman_game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman lets have some fun");
            string words = "iphone,";
            List<string> guess = new List<string>();
            int live = 10;
            Console.WriteLine("hangman game enjoy");
            Console.WriteLine("guess for a {0} letter word", words.Length);
            Console.WriteLine("you have {0} live", live);
            isletter(words, guess);
            while (live > 0)
            {
                string input = Console.ReadLine();
                if (guess.Contains(input))
                {
                    Console.WriteLine("you entered letter [{0}] already", input);
                    Console.WriteLine("try a different letter");
                    GetAlphabet(input);
                    continue;
                }
                guess.Add(input);
                if (Isword(words, guess))
                {
                    Console.WriteLine(words);
                    Console.WriteLine("good");
                    break;
                }
                else if (words.Contains(input))
                {
                    Console.WriteLine("great");
                    string letters = isletter(wordlist: words, guess);
                    Console.Write(letters);
                }
                else
                {
                    Console.WriteLine("wrong letter");
                    live -= 1;
                    Console.WriteLine("live left {0} live", live);

                }
                Console.WriteLine();
                if (live == 0)
                {
                    Console.WriteLine("game over word was [ {0} ]", words);
                    break;

                }
            }
            Console.ReadKey();
        }

        static bool Isword(string words, List<string> guess)
        {
            bool word = false;
            for (int i = 0; i < words.Length; i++)
            {
                string c = Convert.ToString(words[i]);
                if (guess.Contains(c))
                {
                    word = true;
                }
                else
                {
                    return word = false;

                }
            }
            return word;
        }
        static string isletter(string wordlist, List<string> randgen)
        {
            string correctletters = "";
            for (int i = 0; i < wordlist.Length; i++)
            {
                string c = Convert.ToString(wordlist[i]);
                if (randgen.Contains(c))
                {
                    correctletters += c;
                }
                else
                {
                    correctletters += "- ";
                }

            }
            return correctletters;
        }
        static void GetAlphabet(string letters)
        {
                List<string> alphabet = new List<string>();
                for (int i = 1; i <= 26; i++)
                {
                    char alpha = Convert.ToChar(i + 96);
                    alphabet.Add(Convert.ToString(alpha));
                }
                int num = 49;
                Console.WriteLine("non used letters are");
                for (int i = 0; i < num; i++)
                {
                    if (letters.Contains(letters))
                    {
                        alphabet.Remove(letters);
                        num -= 1;
                    }
                    Console.Write("[" + alphabet[i] + "] ");
                }
                Console.WriteLine();
        }
    }
}
