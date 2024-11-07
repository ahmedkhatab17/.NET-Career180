using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD06
{
    public static class GeoshapeUtility
    {
        public static float pi;
        public static float Theta;


        //static constructor 
        //executed once per class called  at runtime
        static GeoshapeUtility()
        {
            pi = 3.14f;
            Theta = 123.3F;
        }

        ///failure in open closed principle
        public static double SumOfAreas(Rect[] rects, Square[] squares, Tri[] tris)
        {
            double sum = 0;
            for (int i = 0; i < rects.Length; i++)
            {
                sum += rects[i].CArea();
            }
            for (int i = 0; i < squares.Length; i++)
            {
                sum += squares[i].CArea();
            }
            for (int i = 0; i < tris.Length; i++)
            {
                sum += tris[i].CArea();
            }
            return sum;
        }
        //succeed in open closed principle
        public static double SumOfAreasV2(Geoshape[] shapes)
        {
            double sum = 0;
            for(int i = 0; i < shapes.Length; i++)
            {
                sum+=shapes[i].CArea();
            }
            return sum;
        }
    }
}
