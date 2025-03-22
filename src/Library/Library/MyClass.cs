using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library
{
    public class MyClass
    {
        public static double MaxOf3Expr(double a, double b)
        {
            if (b == 0)
                throw new Exception("Incorrect second number: can't be 0");
            double x = Math.Cos((Math.Pow(a + b, 2)));
            double y = Math.Sin(a + b);
            double z = a / b;
            if (x >= y && x >= z)
                return x;
            else if (y >= z && y >= x)
                return y;
            else
                return z;
        }
        public static int CountInArray(int[] array, int n)
        {
            if (array.Length != 10)
                throw new Exception("Array length is not 10");
            if (n <= 0)
                throw new Exception("Number is not natural");
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == n)
                    count++;
            }
            return count;
        }
        public static int CountInRandomString(char c)
        {
            Random r = new Random();
            int length = r.Next();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[r.Next(s.Length)]).ToArray());
            int count = 0;
            for (int i = 0; i < randomString.Length; i++)
            {
                if (randomString[i] == c)
                    count++;
            }
            return count;
        }
        public static int MaxElementCount(double[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Max())
                    count++;
            }
            return count;
        }
        public static double[,] ReplaceDiagonalTo0(double[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            int count = rows < columns ? rows : columns;
            for (int i = 0; i < count; i++)
            {
                matrix[i, i] = 0;
            }
            return matrix;
        }
        public static double[,] ReplaceNegativeTo1(double[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            if (rows != columns)
                throw new Exception("Matrix is not square");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                        matrix[i, j] = 1;
                }
            }
            return matrix;
        }
        public static double SumMinInRows(double[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                double minInRow = matrix[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (matrix[i, j] < minInRow)
                        minInRow = matrix[i, j];
                }
                sum += minInRow;
            }
            return sum;
        }
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string AddSimbols(string str)
        {
            return "++++-----" + str;
        }
        public static string RepeatSimbol(char c, int length)
        {
            string str = "";
            for(int i = 0; i < length; i++)
            {
                str += c;
            }
            return str;
        }
        public static double SumFirstElements(double[] array, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
