using System;
using System.Collections;
using System.Collections.Generic;

namespace Scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int unicode;
            int score = 0;
            string userWord;
            
            List<string> alphabet = new List<string>(26);
            int[] values = new int[] {1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10};

            for(i = 0; i < 26; i++)
            { // fill up alphabet array
                unicode = 65 + i;
                char character = (char)unicode;
                alphabet.Add(character.ToString());
            }

            Console.WriteLine("Scrabble Calculator");
            Console.Write("Please enter a word: ");
            userWord = Console.ReadLine();

            // caclulate score
            for(i = 0; i < userWord.Length; i++)
            {
                for(j = 0; j < 26; j++)
                {
                    if(userWord[i].ToString().ToUpper().Equals(alphabet[j]))
                    {
                        score += values[j];
                    }
                }
            }

            Console.WriteLine("The score of " + userWord + " is " + score.ToString());
        }
    }
}
