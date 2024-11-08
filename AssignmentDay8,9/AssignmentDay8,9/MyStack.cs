using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8_9
{
    public class MyStack<MR> where MR : new()
    {
        MR[] arr;
        int tos, size;
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
        public void Push(MR value)
        {
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
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
            }
            return result;
        }
    }
}
