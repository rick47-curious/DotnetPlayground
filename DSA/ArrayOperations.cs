using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPlayground.DSA
{
    public class ArrayOperations
    {

        //Insertions
        public void InsertAtLastIndex(int element, int[] array)
        {
            //Track last item index
            int length = array.Length-1;

            //Assign the last index with the new element
            array[length] = element;

        }

        public void InsertAtFirstIndex(int element, int[] array) 
        {
            int start = array.Length - 2;
            for (int i = start; i >= 0; i--)
            {
                //Moving each element to next block for letting first index free
                array[i+1] = array[i];
            }

            //Assign the first element to the first index
            array[0] = element;

        }

        public void InsertAnyIndex(int position, int element, int[] array) 
        {
            int end = position - 1;
            int start = array.Length - end;
            //Moving each element from the given position to the next position
            for (int i = start; i >= end; i--)
            {
                array[i + 1] = array[i];
            }
            //Assigning the element in the given position
            array[position - 1] = element;

        }

        //Deletions
        public void DeleteFromEnd(int[] array) 
        {
            //Get the last index of the array
            int end = array.Length-1;
            array[end] = 0;
        }

        public void DeleteFromFirst(int[] array)
        {
            //Start index should start right after the first index i.e. 0
            int start = 1;

            //Shift all the elements to the left
            for (int i = start; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }

        }

        public void DeleteFromAnyIndex(int position, int[] array) 
        { 
            //Assign the start (index + 1)
            int start = position;

            for (int i = start; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = 0;
        }
    }
}
