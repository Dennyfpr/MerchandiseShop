using System;
using System.Collections.Generic;

namespace MerchandiseShop
{
    public class AppMenu
    {
        public static int Login()
        {          
            return UI.Login();
        }
        public static void Admin(List<Merchandise> merchList)
        {
            Console.Clear();          
            switch (UI.MenuAdmin())
            {
                case 1:
                    Console.Clear();
                    Logic.DaftarMerch(merchList);
                    UI.BackToMenuAdmin(merchList);
                    break;
                case 2:
                    Console.Clear();
                    UI.CrtMerch(merchList);
                    UI.BackToMenuAdmin(merchList);
                    break;
                case 3:
                    Console.Clear();
                    UI.UpdMerch(merchList);
                    UI.BackToMenuAdmin(merchList);
                    break;
                case 4:
                    Console.Clear();
                    UI.DelMerch(merchList);
                    UI.BackToMenuAdmin(merchList);
                    break;
                case 5:
                    Console.WriteLine(UI.Exit());
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(UI.Invalid());
                    break;
            }
        }
        public static void Customer(List<Merchandise> merchList)
        {
            Console.Clear();
            UI.CfmCart(merchList, Logic.PesanMerch(merchList));
        }
    }
}
