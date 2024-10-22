using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD02
{
    public class Complex
    {
        #region Data Fields
        int real;
        int img;
        #endregion
        #region Setters& getters  [Gates]
        public void SetReal(int _real) {  real = _real; }
        public void SetImg(int _img) { img = _img; }
        public int GetReal() { return real; }
        public int GetImg() { return img; }
        #endregion
        #region Print
        public string Print()
        {
            //if()
            return $"{real}+{img}i";
        }
        #endregion

        #region Function to Add 2 Complex Numbers
        ////caller c1
        //public Complex Add(Complex left,Complex right) 
        //{
        //    Complex result = new Complex();
        //    result.real=left.real+right.real;
        //    result.img=left.img+right.img;
        //    return result;
        //}
        //caller c1
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = /*caller*/real + right.real;
            result.img = /*caller*/img + right.img;
            return result;
        }
        #endregion
    }
}
