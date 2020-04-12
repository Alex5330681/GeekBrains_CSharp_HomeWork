
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Task2_messageClass
{
    public static class Message
{

    static string[] stringToArray(string msg)
    {
        Regex regex = new Regex(@"\w+");
        string[] msgArray = new string[regex.Matches(msg).Count];
        int i = 0;
        foreach (Match word in regex.Matches(msg))
        {
            msgArray[i] = word.ToString();
            i++;
        }
        return msgArray;
    }

   public static void CustomWord(string msg, int wordLength)
    {
        string[] msgArray = stringToArray(msg);

        for (int i = 0; i < msgArray.Length; i++)
        {
            if (msgArray[i].Length <= wordLength)
            {
                Console.Write($"{msgArray[i]} ");
            }
        }
        Console.WriteLine();
    }

   public static string WordRemove (string msg, char symbol)
    {
        string[] msgArray = stringToArray(msg);
        string newMSg = "";

        for (int i = 0; i < msgArray.Length; i++)
        {
            if (msgArray[i][msgArray[i].Length - 1] != symbol)
            {
                newMSg = newMSg + msgArray[i] + " ";
            }
        }
        newMSg.TrimEnd(' ');
        return newMSg;
    }

    public static void WordRemove(ref string msg, char symbol)
    {
        string[] msgArray = stringToArray(msg);
        for (int i = 0; i < msgArray.Length; i++)
        {
            if (msgArray[i][msgArray[i].Length - 1] == symbol)
            {
                msg.Replace(msgArray[i], "");
            }
        }
    }

    public static string MaxWord(string msg)
    {
        string[] msgArray = stringToArray(msg);
        int max = msgArray[0].Length;
        string word = msgArray[0];

        for (int i = 1; i < msgArray.Length; i++)
        {
            if (msgArray[i].Length > max)
            {
                max = msgArray[i].Length;
                word = msgArray[i];
            }
        }
        return word;
    }

   public static string MaxWordString(string msg)
    {
        StringBuilder maxWords = new StringBuilder();
        string[] msgArray = stringToArray(msg);
        int max = msgArray[0].Length;
        for (int i = 1; i < msgArray.Length; i++)
        {
            if (msgArray[i].Length > max)
            {
                max = msgArray[i].Length;
            }
        }
        for (int i = 0; i < msgArray.Length; i++)
        {
            if (msgArray[i].Length == max)
            {
                maxWords.Append(msgArray[i]);
                maxWords.Append(" ");
            }
        }
        return maxWords.ToString().TrimEnd(' ');
    }

   public static void TextAnalysis(string[] array, string text)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < array.Length; i++)
        {
            Regex regex = new Regex(array[i]);
            dict[array[i]] = regex.Matches(text.ToLower()).Count;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} - {dict[array[i]]}");
        }
    }

}
}


