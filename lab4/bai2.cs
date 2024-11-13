using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class bai2
    {
        public double SoNguyen(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("b phai khac 0");
            }
            else if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            {
                return a / b;
            }
            else
            {
                throw new ArgumentOutOfRangeException("a và b phải trong khổng từ 0 đến 10");
            }
        }
    }
}
