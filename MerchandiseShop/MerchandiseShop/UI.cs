using System;
using System.Collections.Generic;
using System.Text;

namespace MerchandiseShop
{
    public class UI
    {
        public static int Login()
        {
            Console.WriteLine("Selamat datang di aplikasi On Me Gallery");
            Console.WriteLine("1. Login sebagai Administrator");
            Console.WriteLine("2. Login sebagai Pelanggan OMG");
            Console.WriteLine("3. Keluar Aplikasi");
            Console.Write("Login: "); int login = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return login;
        }
        public static int MenuAdmin()
        {
            Console.WriteLine("Selamat datang Admin! Ada yang bisa dibantu?");
            Console.WriteLine("1. Cek Daftar Merchandise");
            Console.WriteLine("2. Tambahkan Item Merchandise");
            Console.WriteLine("3. Ubah Item Merchandise");
            Console.WriteLine("4. Hapus Item Merchandise");
            Console.WriteLine("Pilih Angka: "); int menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return menu;
        }
        public static void CrtMerch(List<Merchandise> merchList)
        {
            Console.WriteLine("==== Menambahkan Merchandise Baru ====");
            Console.WriteLine("Masukkan Tipe Merch: "); String typeC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Masukkan Warna Merch: "); String colorC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Masukkan Harga Merch: "); int priceC = Convert.ToInt32(Console.ReadLine());
            Logic.TambahMerch(merchList, typeC, colorC, priceC);
            Console.WriteLine("Merchandise berhasil ditambahkan!");
            Console.WriteLine();
        }
        public static void UpdMerch(List<Merchandise> merchList)
        {
            Console.WriteLine("==== Memperbaharui Info Merchandise ====");
            Logic.DaftarMerch(merchList);
            Console.WriteLine("Pilih nomor merchandise yang ingin diubah: "); int noU = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"'{merchList[noU].Tipe} {merchList[noU].Warna}, Rp. {merchList[noU].Harga}'");
            Console.WriteLine();
            Console.WriteLine("Perbaharui Tipe Merch: "); String typeU = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Perbaharui Warna Merch: "); String colorU = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Perbaharui Harga Merch: "); int priceU = Convert.ToInt32(Console.ReadLine());
            Logic.UbahMerch(merchList, noU, typeU, colorU, priceU);
            Console.WriteLine("Merchandise berhasil diperbaharui!");
            Console.WriteLine();
        }
        public static void DelMerch(List<Merchandise> merchList)
        {
            Console.WriteLine("==== Menghapus Merchandise ====");
            Logic.DaftarMerch(merchList);
            Console.WriteLine("Pilih nomor merchandise yang ingin dihapus: "); int noD = Convert.ToInt32(Console.ReadLine());
            Logic.HapusMerch(merchList, noD);
            Console.WriteLine("Merchandise berhasil dihapus!");
            Console.WriteLine();
        }
        public static void CfmCart(List<Merchandise> merchList, int totalHarga)
        {
            Console.Write("Konfirmasi Pembelian: [Ya/Tidak] "); String cfm = Convert.ToString(Console.ReadLine());
            switch (cfm)
            {
                case "Ya":
                    Console.WriteLine("Pembelian telah dikonfirmasi! Harap lakukan Transfer sebanyak " + totalHarga + " IDR ke Rekening OMG");
                    Console.WriteLine("Pembayaran telah dikonfirmasi! Barang akan segera bisa diambil di Toko OMG dalam 5 hari kerja setelah pembayaran terkonfirmasi.");
                    Console.WriteLine("Terima kasih telah memesan Merchandise Limited OMG ^^");
                    Console.WriteLine(Exit());
                    break;
                case "Tidak":
                    Console.WriteLine("Pembelian dibatalkan, keranjang dikosongkan. Kembali ke Menu Utama...");
                    AppMenu.Customer(merchList);
                    break;
                default:
                    Console.WriteLine(Invalid());
                    break;
            }
        }
        public static String Invalid()
        {
            return "Respon Invalid, aplikasi diterminasi.";
        }

        public static String Exit()
        {
            return "Keluar dari aplikasi...";
        }
        public static void BackToMenuAdmin(List<Merchandise> merchList)
        {
            Console.WriteLine("Kembali ke Menu Utama? [Ya/Tidak] "); String ans = Convert.ToString(Console.ReadLine());
            switch (ans)
            {
                case "Ya":
                    AppMenu.Admin(merchList);
                    break;
                case "Tidak":
                    Console.WriteLine(Exit());
                    break;
                default:
                    Console.WriteLine(Invalid());
                    break;
            }
        }
    }
}
