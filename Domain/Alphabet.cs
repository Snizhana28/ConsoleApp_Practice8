using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class Alphabet
    {

        private List<char> letters;
        public Alphabet()
        {
            letters = new List<char>();
            for (int i = 0; i < 26; i++)
            {
                letters.Add((char)(i + 65));
            }
        }
        public IEnumerator<char> GetEnumerator()
        {
            foreach (var item in letters)
            {
                yield return item;
            }
        }
    }
}
