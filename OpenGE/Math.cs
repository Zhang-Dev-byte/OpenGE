using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGE
{
    public class Random
    {
        public static int Next(int start, int end){
            return new System.Random().Next(start,end);
        }
    }
    public class Math
    {
        public static float cos(float input)
        {
            return MathF.Cos(input);
        }
        public static double cos(double input)
        {
            return System.Math.Cos(input);
        }

        public static float cosh(float input)
        {
            return MathF.Cosh(input);
        }
        public static double cosh(double input)
        {
            return System.Math.Cosh(input);
        }

        public static float acos(float input)
        {
            return MathF.Acos(input);
        }
        public static double acos(double input)
        {
            return System.Math.Acos(input);
        }

        public static float acosh(float input)
        {
            return MathF.Acosh(input);
        }
        public static double acosh(double input)
        {
            return System.Math.Acosh(input);
        }

        public static float abs(float input)
        {
            return MathF.Abs(input);
        }
        public static double abs(double input)
        {
            return System.Math.Abs(input);
        }

        public static float sin(float input)
        {
            return MathF.Sin(input);
        }
        public static double sin(double input)
        {
            return System.Math.Sin(input);
        }

        public static float sinh(float input)
        {
            return MathF.Sinh(input);
        }
        public static double sinh(double input)
        {
            return System.Math.Sinh(input);
        }

        public static float sign(float input)
        {
            return MathF.Sign(input);
        }
        public static double sign(double input)
        {
            return System.Math.Sign(input);
        }

        public static float asin(float input)
        {
            return MathF.Asin(input);
        }
        public static double asin(double input)
        {
            return System.Math.Asin(input);
        }
        public static float asinh(float input)
        {
            return MathF.Asinh(input);
        }
        public static double asinh(double input)
        {
            return System.Math.Asinh(input);
        }


    }
}
