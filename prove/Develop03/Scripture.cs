using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
        private Scripture _reference;

        private List<Word> _word = new List<Word>();

        public void HidenRandomWords(int numberToHide)
        {

        }

        public string GetDisplayText()
        {
            return"";
        }

        public bool IsCompletelyHidden()
        {
            return true;
        }
    }
}