using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuHopTrang
{
    public class KiemThuCode
    {

        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;
            if (A > B)
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            else
                if (B > C)
                Maximum = B;
            else
                Maximum = C;
            return Maximum;
        }

        public int Max(int a, int b, int c)
        {
            int max = 0;

            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;

            if (max < b)
                max = b;

            if (max < c)
                max = c;
            return max;
        }

        public string Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;

            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return "Not a Triangle";
                else if ((b + c) <= a)
                    return "Not a Triangle";
                else if ((a + c) <= b)
                    return "Not a Triangle";
                else return "Triangle is Scalene";
            else if (match == 1)
                if ((a + c) <= b)
                    return "Not a Triangle";
                else return "Triangle is Isosceles";
            else if (match == 2)
                if ((a + c) <= b)
                    return "Not a Triangle";
                else return "Triangle is Isosceles";
            else if (match == 3)
                if ((b + c) <= a)
                    return "Not a Triangle";
                else return "Triangle is Isosceles";
            else return "Triangle is Equilateral";
        }

        public double Average(double Sum, double Count)
        {
            if (Count == 1) return Sum;
            else if (Count > 0) return Sum / Count;
            else return 0;
        }

        public string GiaiPhuongTrinhBac2(float a, float b, float c)
        {
            float delta;
            float x1, x2;
            if (a == 0)
                return "error";
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    return "no results";
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        return "x1 = x2 = " + x1;
                    }
                    else
                    {
                        x1 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                        x2 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                        return "x1 = " + x1 + ";x2 = " + x2;
                    }
                }
            }
        }

        public string Bai09(float a, float b, float x)
        {
           if (a > b)
                return "error";
           else
                if (x < a)
                    return a + "";
                else
                    if (x > b)
                        return b + "";
                    else
                        return x + "";
           
        }

        public bool Bai10(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <=0)
                return false;
            else
                if (a + b <= c)
                    return false;
                else
                    if (a + c <= b)
                        return false;
                    else
                        if (b + c <= a)
                            return false;

                        else
                            return true;
        }

        public string Bai11(out float x, out float y, float w, float h, float ww, float wh)
        {
            x = 0; y = 0;
            if (w <= 0 || h <= 0 || ww <= 0 || wh <= 0)
                return "error";
            else
            {
                if (w > ww)
                    x = 0;
                else
                    x = (ww - w) / 2;

                if (h > wh)
                    y = 0;
                else
                    y = (wh - h) / 2;
                return "x = " + x + "; y = " +1 x;
            }
        }

    }
}
