using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Letter;

public class WorkFindMissingLetter
{
    public static char FindMissingLetter(char[] array)
    {
        int counter = 0;
        char[] LetterEn = new char[]
        {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        for (int i = 0; i < LetterEn.Length; i++)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (Char.IsUpper(array[k]))
                {
                    counter++;
                    array[k] = Char.ToLower(array[k]);
                }
            }
            if (array[0] != LetterEn[i])
            {
                continue;
            }
            else
            {
                foreach (char c in array)
                {
                    if (c != LetterEn[i])
                    {
                        if (counter == 0)
                        {
                            return LetterEn[i];
                        }
                        else
                        {
                            return Char.ToUpper(LetterEn[i]);
                        }
                    }
                    i++;
                }
            }
        }
        return ' ';
    }
}
