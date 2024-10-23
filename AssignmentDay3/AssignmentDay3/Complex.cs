using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
    public class Complex
    {

        int real;
        int img;

        public void setReal(int _real) {  real = _real; }
        public void setImg(int _img) { img = _img; }
        public int getReal() { return real; }
        public int getImg() { return img; }

        public string print()
        {
            if (real == 0 && img == 0)
                return "0";             ///0   0    0

            if (real == 0)
            {
                if (img == 1)
                    return "i";
                else if (img == -1)
                    return "-i";
                else                       ///0    1   i
                    return $"{img}i";      ///0   -1   -i
            }

            if (img == 0)
                return $"{real}";   ///0   0    0
                                    ///10  0    10


            if (img == 1)
                return $"{real}+i";  ///3    1   3+i
            else if (img == -1)
                return $"{real}-i";  ///3   -1   3-i
            else if (img > 0)
                return $"{real}+{img}i";
            else
                return $"{real}{img}i";
        }

        #region Function to Add 2 Complex Numbers

        //caller c1
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = this.real + right.real;
            result.img = img + right.img;
            return result;
        }
        #endregion

        public Complex()
        {
            real = 5; img = 10;
        }
        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }
        public Complex(int num)
        {
            real = img = num;
        }

        
    }
}
