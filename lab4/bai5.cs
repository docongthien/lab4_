using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class bai5
    {
        public string GetName(string name)
        {
            if(name.Length >= 5 && name.Length <= 10) 
            {
                if (name == "")
                {
                    throw new NullReferenceException("Đối tượng hồ sơ là null.");
                }
                return name;
            }
            throw new ArgumentOutOfRangeException("name từ 5-10 kí tự");

        }
    }
}
