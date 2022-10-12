using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_A_20170140031
{
    class program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] rahmat = new int[51];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukkan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 51)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 51 elemen. \n");

            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                rahmat[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun4
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int rt = 0; rt < n; rt++)
            {
                Console.WriteLine(rahmat[rt]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // Pada pas i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int rt = 0; rt < n - i; rt++)
                {
                    if (rahmat[rt] > rahmat[rt + 1]) //Jika elemen tidak dalam urutan  yang benar
                    {
                        // Tuker elemen
                        int temp;
                        temp = rahmat[rt];
                        rahmat[rt] = rahmat[rt + 1];
                        rahmat[rt + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            program myList = new program();
            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit/Keluar Console
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar. ");
        }
    }
}