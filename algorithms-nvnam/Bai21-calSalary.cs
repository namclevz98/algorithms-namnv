using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai21_calSalary
    {
        public static double CalSalary(double salary, int n)
        {
            if (n == 0)
            {
                return salary;
            }
            for (int i = 0; i < n; i++)
            {
                salary += salary * 0.1;
            }    
            return salary;
        }
        public static double CalSalaryRecurse(double salary, int n)
        {
            if( n == 0 )
            {
                return salary;
            }
            return CalSalaryRecurse(salary, n - 1) + CalSalaryRecurse(salary, n - 1) * 0.1;
            // lương  = lương năm trước + 10% lương năm trước
        }
    }
}


