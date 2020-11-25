using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai22_calMonth
    {
        public static int CalMonth(double money, double rate)
        {
            int month = 0;
            double target = 2 * money;
            while (money < target)
            {
                money += money * rate / 100;
                month++;
            }
            return month;
        }
        public static int CalMonthRecurse(double money, double rate)
        {
            int month;
            double target = 2 * money;
            for (month = 1; ; month ++)
            {
                if (CalMoney(money, rate, month) >= target)
                {
                    break;
                }    
            }    
            return month;
        }
        public static double CalMoney(double money, double rate, int month)
        {
            if(month == 0)
            {
                return money;
            }
            return CalMoney(money, rate, month - 1) + CalMoney(money, rate, month - 1) * rate / 100;
        }
    }
}
