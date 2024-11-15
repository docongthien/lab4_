using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class bai3
    {
        public double TinhTrungBinh(double[] so)
        {
            if (so.Length == 0)
            {
                throw new ArithmeticException("Không thể tính trung bình cộng của danh sách rỗng.");
            }

            double tong = 0;
            foreach (double number in so)
            {
                tong += number;
            }
            return tong / so.Length;
        }
    }
}
