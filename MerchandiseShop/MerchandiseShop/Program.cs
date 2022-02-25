using System;
using System.Collections.Generic;
using System.Text;

namespace MerchandiseShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Merchandise> merchToko = new List<Merchandise>();
            merchToko.Add(new Merchandise("Jaket", "Merah", 550000));
            merchToko.Add(new Merchandise("Kaos", "Hijau", 175000));
            merchToko.Add(new Merchandise("Celana", "Biru", 200000));
            merchToko.Add(new Merchandise("Turtleneck", "Hitam", 300000));
            merchToko.Add(new Merchandise("Jas", "Putih", 950000));

            switch (AppMenu.Login())
            {
                case 1:
                    AppMenu.Admin(merchToko);
                    break;
                case 2:
                    AppMenu.Customer(merchToko);
                    break;
                case 3:
                    Console.WriteLine(UI.Exit());
                    break;
                default:
                    Console.WriteLine(UI.Invalid());
                    break;
            }
        }
    }
}
