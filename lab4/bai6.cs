using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class bai6
    {
        public int GetMin(int[] array)
        {
            if (array.Length >= 0 && array.Length <= 5)
            {
                if (array.Length == 0)
                {
                    throw new ArgumentException("Mảng rỗng");
                }
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                        min = array[i];
                }
                return min;
            }
            throw new ArgumentOutOfRangeException("mảng thuộc khoảng 0-5");

        }
    }
}
