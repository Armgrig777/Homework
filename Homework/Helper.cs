using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Helper
    {
        public static void ShowMenu()
        {
            Menu[] menuitems = Enum.GetValues<Menu>();
            foreach (Menu item in menuitems)
            {
                Console.WriteLine($"{(int)item}) {item}");
            }
        }
        public static void ShowDepMenu()
        {
            Headquarters[] menuItems = Enum.GetValues<Headquarters>();

            foreach (Headquarters item in menuItems)
            {
                string strItem = item.ToString().AddSpaceBetween();

                Console.WriteLine($"{(int)item}) {strItem}");
            }
        }

    }
}
