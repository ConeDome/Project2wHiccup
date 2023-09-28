using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    /* 
     * For my hubby Hiccup Haddock cause I didn't know what this john was either
     * 
     * WHAT IS A WHERE CLAUSE: it's almost like an if statement, it adds a constraint to a generic type
     * EX: for our line of code, ISort<T> T is a generic parameter type like string, char, int, etc. and 
     * when we say where T (a generic data type) is comparable then we can use ISort
     * 
     * WHAT IS A CONSTRAINT: 
     * 
     * WHAT CANNOT BE USED FOR ICOMPARABLE: IComparable makes sure its a data type you can sort
     * like you can sort ints, strings, chars, etc. but how (you can't) do you sort pictures?
    */
    internal interface ISort<T> where T : IComparable<T>
    {
        public void Sort(List<T> values);
    }
}



/*
 * CODE THAT MIGHT HELP LATER (JAKE WROTE THIS)
 * class MergeSort<T> : ISort<T> where T : IComparable<T>
{
    public void Sort(List<T> stuff)
    { 
    //merge code
    }
}

//then in the main
ISort mySort = new MergeSort<int>().Sort(myList);
 * 
 */