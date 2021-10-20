using System;
using System.Text;

namespace Lab_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Первое слово: ");
            word = Console.ReadLine();
            var message = Logic.Change(word);
            Console.WriteLine(message);
        }
    }

    public class Logic
    {
        public static string Change(string word)
        {
            StringBuilder word2 = new StringBuilder(word);
            int l = word.Length;

            char c;
            for (int i = 0; i < l; i += 2)
            {
                if (i / 2 == 0)
                {
                    c = word2[i];
                    word2[i] = word2[i + 1];
                    word2[i + 1] = c;
                }
                else
                {
                    break;
                }
            }

            var message = "Второе слово: " + word2;
            return message;
        }
    }
}
