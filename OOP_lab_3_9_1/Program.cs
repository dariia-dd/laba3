using System;

namespace OOP_lab_3_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool doubleDot = false;

            for (int i = 0; i < str.Length; ++i)
            {
                if (doubleDot)
                {
                    Console.Write(str[i]);
                }
                
                if (str[i] == ':')
                {
                    doubleDot = true;
                }
            }

            Console.WriteLine("\n");

            string[] sentences = str.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (words.Length % 2 != 0)
                {
                    ++count;
                }
            }

            Console.WriteLine("Kiлькiсть речень, що мiстять непарну кiлькiсть слiв: {0}", count);
        }
    }
}
