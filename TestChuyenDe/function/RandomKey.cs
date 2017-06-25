using System;

namespace TestChuyenDe.function
{
    class RandomKey
    {
        public static string GetRandomKey(int length)
        {
            string character = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numb = "0123456789";
            string str = character + numb;
            Random random = new Random();
            string key = "";
            for (int i = 0; i < length; i++)
            {
                int randnum = random.Next(str.Length);
                key = key + str[randnum];
            }
            return key;
        }
    }
}
