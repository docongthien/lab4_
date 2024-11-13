using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Bai1
    {
        public double bai1(double a , double b)
        {
            if ( a>=0 && a<=10 && b>=0 && b<= 10 ){
                if (!(double.IsInteger(a) && (double.IsInteger(b))))
                {
                    throw new ArgumentException("a và b không phải là số nguyên");
                }
                else
                {
                    return a * b;
                }
            }
            else
            {
                throw new ArgumentException("a và b thuộc khoảng từ 0 đến 10");
            }

        }
    }
}
