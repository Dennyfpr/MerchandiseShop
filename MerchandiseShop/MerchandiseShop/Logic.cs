using System;
using System.Collections.Generic;
using System.Text;

namespace MerchandiseShop
{
    class Logic
    {
        public static void DaftarMerch(List<Merchandise> merchList)
        {
            Console.Clear();
            Console.WriteLine("Daftar Merchandise On Me Gallery:");
            for (int a = 0; a < merchList.Count; a++)
            {
                Console.WriteLine($"{(a + 1)}. {merchList[a].Tipe} {merchList[a].Warna} Rp. {merchList[a].Harga}");
            }
            Console.WriteLine();
        }

        public static void TambahMerch(List<Merchandise> merchList, String type, String color, int price)
        {
            Merchandise merch = new Merchandise(type, color, price);
            merchList.Add(merch);
            Console.WriteLine();
        }

        public static void UbahMerch(List<Merchandise> merchList, int no, String type, String color, int price)
        {
            DaftarMerch(merchList);
            Console.WriteLine();
            merchList[no-1].Tipe = type;
            merchList[no-1].Warna = color;
            merchList[no-1].Harga = price;
            Console.WriteLine();
        }

        public static void HapusMerch(List<Merchandise> merchList, int no)
        {
            DaftarMerch(merchList);
            Console.WriteLine();
            merchList.RemoveAt(no-1);
            Console.WriteLine();
        }

        public static int PesanMerch(List<Merchandise> merchList)
        {
            Console.Clear();
            Console.WriteLine("Selamat datang di On Me Gallery, apa yang anda ingin pesan hari ini?");
            String ans;
            int totalHarga;
            List<String> namaItem = new List<String>();
            List<int> pcsItem = new List<int>();
            List<int> HargaItem = new List<int>();
            do
            {
                Logic.DaftarMerch(merchList);
                Console.Write("Pilih nomor barang yang ingin dibeli: "); int noItem = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Merchandise.TunjukMerch(merchList[noItem-1].Tipe, merchList[noItem-1].Warna, merchList[noItem-1].Harga);
                Console.Write("Berapa pcs yang ingin anda pesan? "); int pcs = Convert.ToInt32(Console.ReadLine());
                totalHarga = merchList[noItem - 1].Harga * pcs;
                namaItem.Add($"{merchList[noItem - 1].Tipe} {merchList[noItem - 1].Warna}");
                pcsItem.Add(pcs);
                HargaItem.Add(merchList[noItem - 1].Harga * pcs);
                Console.Write("Apakah anda ingin pesan lagi? [Ya/Tidak] "); ans = Convert.ToString(Console.ReadLine());
            } while (ans == "Ya");
            
            Console.Clear();
            Console.WriteLine("Keranjang Anda:");
            for (int a = 0; a < namaItem.Count; a++)
            {
                Console.WriteLine($"- {namaItem[a]} ({pcsItem[a]}), Rp. {HargaItem[a]}");
            }
            return totalHarga;
        }
    }
}
