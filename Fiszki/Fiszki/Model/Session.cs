using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Model
{

    public class Session
    {
        #region Properties

        public int Memorized { get; set; }
        public int NotMemorized { get; set; }
        public int All { get; set; }

        public List<int> NextList {get; set;}
        public int CurrentFlashcard { get; set; }
        public string Theme { get;}

        #endregion

        public Session(string Theme,  int NumberOfWords)
        {
            All = NumberOfWords;
            Memorized = 0;
            NotMemorized = All;

            CurrentFlashcard = 0;

            NextList = new List<int>();

            for (int i = 0; i < All; i++)
            {
                NextList.Add(i);
            }

            this.Theme = Theme;
        }

        public int getNext()
        {
            if (NextList.Count > 0)
                return NextList.First();
            else
                return -1;
        }

        public void addToMemorized()
        {
            CurrentFlashcard = NextList.First();
            NextList.RemoveAt(0);
            Memorized++;
            NotMemorized--;
        }

        public void addToNotMemorized()
        {
            CurrentFlashcard = NextList.First();
            int temp = NextList[0];
            NextList.RemoveAt(0);
            NextList.Add(temp);
        }
    }


}
