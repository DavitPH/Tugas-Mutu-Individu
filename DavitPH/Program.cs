using System;
using System.Xml.Linq;

namespace Bubble_Sort
{
    ///<summary> 
    /// Prgram untuk memasukan data dengan menggunakan algoritma BubbleSor
    /// <\summary>


    ///<summary>
    ///Didalam kelas program terdapat method read, display, bubbleSortArray
    /// </summary>
    class program 
    {
        private int[] a = new int[20]; ///<summary> variabel a array bersivat prifat dengan data maksimal 20 </summary>
        private int n; /// <summary>variabel n bersifat privat </summary> 
        public void read()
        {
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: "); /// <summary>Memunculkan text "Masukan banyaknya elemen pada array: " </summary>

                //Menyimpan data yang dimasukan user
                string s = Console.ReadLine();
                n = Int32.Parse(s);

                ///<summary>
                ///kondisi jika data yang dimasukan lurang dan sama dengan 20 dapat diterima, tetapi lebih dari itu maka akan memunculkan tect Array dapat mempunyai maksimal 20 elemen

                /// <\summary>
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }

            Console.WriteLine(""); /// <summary>Memunculkan text kosong (untuk memberi jarak) </summary>
            Console.WriteLine("--------------------"); //Memunculkan text garis
            Console.WriteLine("Masukan Elemen Array"); /// <summary> Memunculkan text "Masukan Elemen Array" </summary
            Console.WriteLine("--------------------"); //Memunculkan text garis

            /// <summary> looping atau perulangan berdasarkan banyak jumlah data yang tersimpan di variabel n  </summary>
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        public void display() /// <summary> Method untuk menampilkan data yang tersimpan </summary>
        {
            Console.WriteLine(""); //Memunculkan text kosong (untuk memberi jarak)
            Console.WriteLine("-----------------------------------"); //Memunculkan text garis
            Console.WriteLine("Elemental Array yang Telah Tersusun"); /// <summary> Memunculkan text "Elemental Array yang Telah Tersusun" </summary>
            Console.WriteLine("-----------------------------------"); //Memunculkan text garis

            ///<summary>
            ///looping atau perulangan berdasarkan banyak jumlah data yang tersimpan di variabel n 
            ///</summary>
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray() /// <summary> Algoritma BubbleSortArray </summary>
        {
            ///<summary>
            ///looping atau perulangan berdasarkan banyak jumlah data yang tersimpan di variabel n
            /// </summary>
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    /// <summry>
                    /// Memasukan data variabel a array maksimal panjang data 20
                    /// </summry>
       
                    if (a[j] > a[j + 1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ///<summry>
            ///Membuat sebuah objek baru untuk memanggil method
            /// </summry>
            program myList = new program();

            myList.read(); /// <summary> Memanggil kelas read </summary>
            myList.BubbleSortArray(); ///<summary> Memanggil kelas BubbleSortArray </summary>
            myList.display(); ///<summary> >Memamnggil kelas display </summary\

            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar."); ///<summary> Memunculkan text Tekan Tombol Apa Saja Untuk Keluar </summary>
            Console.Read(); ///<summary> fungsi untuk membaca satu karakter dari input yang diberikan oleh user </summary
        }
    }
}