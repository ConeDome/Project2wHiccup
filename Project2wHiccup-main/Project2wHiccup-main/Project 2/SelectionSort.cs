using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class SelectionSort<T> : ISort<T> where T : IComparable<T>
    {
        public void Sort(List<T> stuff)
        {
            var listMinimum = stuff[0];
            for (int i = 0; i < stuff.Count; i++)
            {
                for (int j = 0; j < stuff.Count; j++)
                {
                    if (stuff[i].CompareTo(stuff[j]) < 0)
                    {
                        var temporary = stuff[i];
                        stuff[i] = stuff[j];
                        stuff[j] = temporary;
                    }
                }
            }
        }
    }
}
