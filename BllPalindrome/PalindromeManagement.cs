using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalPalindrome;

namespace BllPalindrome
{
    public class PalindromeManagement
    {
        public List<string> GetListPalindromeFromFile(string pFileName)
        {
            FileTextReaderUtility myReader = new FileTextReaderUtility();
            List<string> readLines = myReader.ReadAllLines(pFileName);
            List<string> cleannedList = new List<string>();
            foreach (string line in readLines)
            {
                string[] splitted = line.Split(',');

                string cleaned = string.Empty;
                int level = 0;

                foreach (char c in splitted[0])
                {
                    if (c == '(')
                    {
                        level++;
                    }

                    if (level == 0)
                    {
                        cleaned += c;
                    }

                    if (c == ')' && level > 0)
                    {
                        level--;
                    }
                }

                cleannedList.Add(cleaned.Trim());
            }
            
            return cleannedList;

        }
    }
}
