using System;

namespace _15._12._2022_Tekrar_Tapsiriqlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        // Task-1
        static void MakeOneSpace(ref string word)
        {
            word = word.Trim();
            string word2 = "";
            var array = word2.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "")
                {
                    if (word2 != "")
                    {
                        word2 += ' ';
                    }
                    word2 += array[i];
                }
            }
            word = word2;
        }

        // Task-2
        static int FindWordsCount(string word)
        {
            MakeOneSpace(ref word);
            return word.Split(' ').Length;
        }

        // Task-3
        static void AddInt(ref int[] array, int number)
        {
            int[] Array2 = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                Array2[i] = array[i];
            }
            Array2[Array2.Length - 1] = number;
            array = Array2;
        }

        // Task-4
        static string[] NamesBack(string[] fullnames)
        {
            string[] array = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                array[i] = fullnames[i].Split(' ')[0];
            }
            return array;
        }

        // Task-5
        static bool IsCapitalized(string fullnames)
        {
            if (!Char.IsUpper(fullnames[0]))
            {
                return false;
            }
            for (int i = 1; i < fullnames.Length; i++)
            {
                if (!Char.IsLower(fullnames[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsFullname(string fullnames)
        {
            var words = fullnames.Split(' ');
            if (words.Length != 2)
            {
                return false;
            }
            if (!IsCapitalized(words[0]) || !IsCapitalized(words[1]))
            {
                return false;
            }
            return true;
        }

    }
}
