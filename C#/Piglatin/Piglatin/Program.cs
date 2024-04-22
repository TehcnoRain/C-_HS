using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string phraseIn = "";
            string[] phraseOut;

            Console.Write("Type a word for english to pig latin traslation or hit enter to exit:");
            phraseIn = Console.ReadLine();

            while (phraseIn != "")
            {
                phraseOut = GetTranslation(phraseIn);
                DisplayResults(phraseOut, phraseIn);
                phraseIn = Console.ReadLine();
            }
            Console.WriteLine();
        }

        static string[] GetTranslation(string phraseIn)
        {
            int wordLength = 0;
            int index;
            string wordS = string.Empty;
            StringBuilder pigLatinEnding;
            string[] phraseOut;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            phraseOut = phraseIn.Split(' ');

            for (int i = 0; i < phraseOut.Length; i++)
            {
                wordLength = phraseOut[i].Length;
                index = int.MaxValue;
                pigLatinEnding = new StringBuilder();

                foreach (char c in vowels)
                {

                    if (phraseOut[i].IndexOf(c) < index && phraseOut[i].IndexOf(c) != -1)
                        index = phraseOut[i].IndexOf(c);
                }

                wordS = phraseOut[i].Substring(0, index);
                phraseOut[i] = phraseOut[i].Remove(0, index);
                pigLatinEnding.AppendFormat("-{0}ay", wordS);
                phraseOut[i] = string.Concat(phraseOut[i], pigLatinEnding.ToString());
            }
            return phraseOut;
        }


        static void DisplayResults(string[] phraseOut, string phraseIn)
        {
            Console.Write("Original words: ");
            Console.WriteLine(phraseIn);
            Console.Write("New Words: ");

            foreach (string word in phraseOut)
            {
                Console.WriteLine(word + " ");

            } 
        }
    }
}
