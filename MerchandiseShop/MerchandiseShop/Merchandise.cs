using System;
using System.Collections.Generic;
using System.Text;

namespace MerchandiseShop
{
    public class Merchandise
    {
        private String tipe;
        private String warna;
        private int harga;

        public Merchandise(string type, string color, int price)
        {
            this.tipe = type;
            this.warna = color;
            this.harga = price;
        }

        public string Tipe { get => tipe; set => tipe = value; }
        public string Warna { get => warna; set => warna = value; }
        public int Harga { get => harga; set => harga = value; }

        public static void TunjukMerch(string type, string color, int price)
        {
            Console.WriteLine($"{type} {color} Rp. {price}");
            Console.WriteLine();
        }
    }
}
