using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai23_printMenu
    {
        public static void PrintMenu(List<Menu> menus)
        {
            for (int i = 0; i < menus.Count(); i++)
                if (menus[i].parent_id == 0)
                {
                    Console.WriteLine(menus[i].title);
                    for (int j = 0; j < menus.Count(); j++)
                    {
                        if (menus[j].parent_id == menus[i].id)
                        {
                            Console.WriteLine("--" + menus[j].title);
                            for (int k = 0; k < menus.Count(); k++)
                            {
                                if (menus[k].parent_id == menus[j].id)
                                {
                                    Console.WriteLine("----" + menus[k].title);
                                }
                            }
                        }
                    }
                }
        }
    }
}
