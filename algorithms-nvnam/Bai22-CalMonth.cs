using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai22_CalMonth
    {
        public static int CalMonth(double money, double rate)
        {
            int month = 0;
            double target = 2 * money;
            while (money <= target)
            {
                money += money * rate / 100;
                month++;
            }
            return month;
        }
        //public static int CalMonth_recurse(double money, double rate)
        //{

        //}
    }
}
