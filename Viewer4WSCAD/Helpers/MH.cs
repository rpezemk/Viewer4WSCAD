﻿using System;
using System.Linq;

namespace Viewer4WSCAD.Helpers
{
    public static class MH
    {
        public static double Log2Lin(double inVal, double maxScale = 10)
        {
            return Math.Pow(maxScale, inVal);
        }

        public static double Max(double value, params double[] values) 
        {
            
            
            var max = value;
            if (values.Count() == 0)
                return value;

            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] > max)
                    max = values[i];
            }
            
            return max;
        }

        public static double Min(double value, params double[] values)
        {


            var min = value;
            if (values.Count() == 0)
                return value;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }


    }
}
