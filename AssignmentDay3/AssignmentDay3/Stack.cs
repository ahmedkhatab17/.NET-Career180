using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    public class Stack
    {
        #region Data Fields
        int[] arr;
        int tos;
        int size;
        //this line of code is executed once per program run
        private static int counter = 0;
        #endregion

        #region Counter Getter only
        //static fn dosent have this
        public static int GetCounter()
        {
            return counter;
        }
        #endregion

        #region ctors
        public Stack()
        {
            counter++;
            tos = 0;
            size = 5;
            arr = new int[size];
        }
        public Stack(int _size)
        {
            counter++;
            tos = 0;
            size = _size;
            arr = new int[size];
        }
        #endregion

        #region Stack Functions
        public void Push(/*Stack this,*/int number)
        {
            //if (tos != size)
            if (IsFull())
            {
                resize();
            }
            arr[tos] = number;
            tos++;
        }

        public int Pop()
        {
            int result = -1234;
            //if (tos != 0)
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                //return result;
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
                //return -1234;
                ////Effective way -> throw runtime error
            }
            return result;
        }

        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        public int Peak()
        {
            return arr[tos - 1];
        }

        public void resize()
        {
            size += 1;

            int[] newArr = new int[size];
            for (int i = 0;i < tos; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;

        }

       
        #endregion

    }
}
