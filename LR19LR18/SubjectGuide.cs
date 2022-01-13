using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR19LR18
{
    class SubjiectGuide
    {
        string word;
        int[] page;

        public SubjiectGuide(string word, int[] page)
        {
            this.word = word;
            this.page = page;
        }


        public static void InputFromFile(List<SubjiectGuide> TargetSG, string FileName)
        {
            try
            {
                string InputText = File.ReadAllText(FileName);
                string patern = @"[A-Z]*[a-z]*";
                MatchCollection wordsMatches = Regex.Matches(InputText, patern);
                List<string> words = new List<string>();
                foreach (Match value in wordsMatches)
                {
                    if (value.ToString() != "," && value.ToString() != "")
                    {
                        words.Add(value.ToString());
                    }
                }
                List<int[]> pages = new List<int[]>();
                for (int i = 0; i < words.Count; i++)
                {
                    string SubCat;
                    if (i < words.Count - 1)
                    {
                        SubCat = InputText.Substring(InputText.IndexOf(words[i]), InputText.IndexOf(words[i + 1]) - InputText.IndexOf(words[i]) - 1);
                    }
                    else
                    {
                        SubCat = InputText.Substring(InputText.IndexOf(words[i]));

                    }
                    patern = @"[0-9]+";
                    MatchCollection pagesMatches = Regex.Matches(SubCat, patern);
                    int[] pagesTemp = new int[pagesMatches.Count];
                    for (int j = 0; j < pagesTemp.Length; j++)
                    {
                        pagesTemp[j] = Convert.ToInt32(pagesMatches[j].ToString());
                    }
                    pages.Add(pagesTemp);
                    SubjiectGuide SGtemp = new SubjiectGuide(words[i], pages[i]);
                    TargetSG.Add(SGtemp);
                }
                
            }
            finally
            {
                Console.WriteLine();
            }
           
        }

        public static void InputFromKeyboard(List<SubjiectGuide> TargetSG)
        {
            try
            {
                Console.WriteLine("Введите слово");
                string word = Console.ReadLine();
                Console.WriteLine("Введите страницы. Для нескольких значений используйте символ \",\"");
                string pagesInStr = Console.ReadLine();
                List<int> pages = new List<int>();
                string pattern = @"[0-9]+";
                MatchCollection Matches = Regex.Matches(pagesInStr, pattern);
                foreach (Match value in Matches)
                {
                    pages.Add(Convert.ToInt32(value.ToString()));
                }
                SubjiectGuide tempSG = new SubjiectGuide(word, pages.ToArray());
                TargetSG.Add(tempSG);
            }
            finally
            {
                Console.WriteLine();
            }
         
            
        }
        public override string ToString()
        {
            string result = this.word + " ";
            foreach (int value in page)
            {

                result += value.ToString();
                result += ",";
            }
            return result;
        }
    }
    
}