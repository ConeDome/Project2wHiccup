using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class MergeSort<T> : ISort<T> where T: IComparable<T>
    {
        public void Sort(List<T> stuff, int min, int max) 
        { 
        
        }
        public void Sort(List<T> stuff)
        {
            if (stuff.Count <= 1)
            {
                return stuff;
            }

            List<T> firstHalf = new List<T>();
            List<T> secondHalf = new List<T>();

            for (int i = 0; i < stuff.Count/2; i++)
            {
                firstHalf.Add(stuff[i]);
            }
            for (int i = 0; i < stuff.Count/2; i++)
            {
                secondHalf[i] = stuff[i + firstHalf.Count];
            }

            Sort(firstHalf);
            Sort(secondHalf);
            List<T> sortedStuff = Merge(firstHalf, secondHalf);
            return sortedStuff;
        }

        public List<T> Merge(List<T> firstHalf, List<T> secondHalf)
        {
            List<T> fullList = new List<T>();
            while (firstHalf.Count() > 0)
            {
                fullList.Add(firstHalf[0]);
                firstHalf.RemoveAt(0);
            }
            while (secondHalf.Count() > 0)
            {
                fullList.Add(secondHalf[0]);
                secondHalf.RemoveAt(0);
            }
            for (int i = 0; i < fullList.Count; i++)
            {
                for (int j = 0; j < fullList.Count; j++)
                {
                    if (fullList[i].CompareTo(fullList[j]) < 0)
                    {
                        var temporary = fullList[i];
                        fullList[i] = fullList[j];
                        fullList[j] = temporary;
                    }
                }
            }
            return fullList;
        }

    }
}
