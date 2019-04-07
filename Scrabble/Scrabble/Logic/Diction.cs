using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scrabble.Logic
{
    class Diction
    {
        private SortedSet<String> dic = new SortedSet<string>();
        public Diction()
        {
            using (StreamReader sr = new StreamReader("Dictionary.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dic.Add(line);
                }
            }
        }
        public bool FindWord(String word)
        {
            return dic.Contains(word);
        }
        public void DeleteNotNeeded()
        {
            StringBuilder result = new StringBuilder("");
            using (StreamReader sr = new StreamReader("Dictionary.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int i = 0;
                    int index = line.IndexOf('\t');
                    if (index >= 0)
                    {
                        line = line.Remove(index);
                    }
                    result.Append(line).Append("\r\n");
                    if (i % 1000 == 0)
                    {
                        Console.WriteLine("работает");
                    }
                    i++;
                }
            }
            using (StreamWriter sw = new StreamWriter("Dictionary.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
        }
        public void DeleteRepeade()
        {
            StringBuilder result = new StringBuilder("");
            using (StreamReader sr = new StreamReader("Dictionary.txt"))
            {
                string line;
                SortedSet<string> dick = new SortedSet<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    String[] str = line.Split(' ');
                    int i = 0;
                    for (int j = 0; j < str.Length; j++)
                    {
                        dick.Add(str[j]);
                    }
                    if (i % 1000 == 0)
                    {
                        Console.WriteLine("работает");
                    }
                    i++;
                }
                foreach (var str in dick)
                {
                    bool flag = true;
                    char[] s = str.ToCharArray();
                    for (int i = 1; i < str.Length; i++)
                    {
                        if ((!Char.IsLetter(s[i])) || Char.IsUpper(s[i]))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        result.Append(str).Append("\r\n");
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("Dictionary.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
        }
    }
}
