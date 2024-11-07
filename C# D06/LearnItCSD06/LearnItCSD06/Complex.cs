﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD06
{
    public class Complex
    {
        #region Data Fields
        int real;
        int img;
        #endregion

        #region Properties
        public int Real
        {
            get
            {
                return real;
            }

            set
            {
                real = value;
            }
        }

        public int Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }
        #endregion

        #region Auto Property [instead of data fields + properties]
        //public int Real { get; set; }
        //public int Img { get; set; }
        #endregion

        #region Print
        public override string ToString()
        {
            return $"{real}+{img}i";
        }
        #endregion

        #region Function to Add 2 Complex Numbers

        //caller c1
        public Complex Add(/*Complex this,*/Complex right)
        {
            Complex result = new Complex();
            result.Real = this.Real + right.Real;
            result.Img = Img + right.Img;
            return result;
        }
        #endregion

        #region Ctors
        //default ctor generated by o.s [CLR] if there is no such ctor
        public Complex()
        {
            Real = 3; Img = 4;
        }
        public Complex(int _real, int _img)
        {
            Real = _real;
            Img = _img;
        }
        public Complex(int _num)
        {
            Real = Img = _num;
        }
        #endregion

        #region Operators
        //c1+c2
        public static Complex operator +(Complex left, Complex right) 
        {
            Complex result= new Complex();
            result.real= left.Real + right.Real;
            result.img= left.Img + right.Img;
            return result;
        }

        //c1+10
        public static Complex operator+(Complex left,int num)
        {
            Complex result= new Complex();
            result.real= left.Real + num;
            result.img = left.Img; //REMEBER Dont forget
            return result;
        }

        //++c1 , c1++
        public static Complex operator ++(Complex left)
        {
            return new Complex { Real=left.real+1, Img=left.img+1 };
        }

        //c1>c2
        public static bool operator>(Complex left,Complex right)
        {
            return left.real>right.real && left.img>right.img;
        }
        //c1<c2
        public static bool operator <(Complex left, Complex right)
        {
            return left.real < right.real && left.img < right.img;
        }
        //c1==c2
        public static bool operator ==(Complex left, Complex right)
        {
            return left.real == right.real && left.img == right.img;
        }
        //c1!=c2
        public static bool operator !=(Complex left, Complex right)
        {
            return !(left == right);
        }

        public static implicit operator int(Complex left) 
        {
            return left.real;
        }

        public static explicit operator string(Complex left) 
        {
            return left.ToString();
        }
        #endregion

        
    }
}