using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD08
{
    //Generic Constraints
    //1- primary constraints 
    //   0..1
    //   special primary constraints special class
    //2- secondary constraints 
    //   0..M
    //3- ctorless constraints
    public class MyStack<MR> where MR:new()
    {
        #region Data Fields
        MR[] arr;
        int tos;
        int size;
        #endregion
        #region Counter Getter only
        #endregion
        #region ctors
        public MyStack()
        {
            tos = 0;
            size = 5;
            arr = new MR[size];
        }
        public MyStack(int _size)
        {
            tos = 0;
            size = _size;
            arr = new MR[size];
        }
        #endregion
        #region Stack Functions
        public void Push(/*Stack this,*/MR value)
        {
            //if (tos != size)
            if (!IsFull())
            {
                arr[tos] = value;
                this.tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!");
            }
        }

        public MR Pop()
        {
            MR result = default;
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
        public MR Peak()
        {
            return arr[tos - 1];
        }
        #endregion
    }

}
