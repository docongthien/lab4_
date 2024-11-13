using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class bai4
    {
        public static int mang(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("nằm ngoài khoảng");
            }
            return array[index];
        }
    }
}
