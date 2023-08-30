// namespace ContohNamespace
// {
//     // Kelas private
//      class KelasPrivate
//     {
//         // Anggota kelas private
//         private int angka;

//         // Konstruktor
//         public KelasPrivate(int nilai)
//         {
//             angka = nilai;
//         }

//         // Metode public yang mengakses anggota private
//         public void TampilkanAngka()
//         {
//             Console.WriteLine("Nilai angka: " + angka);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Membuat objek dari kelas private
//             KelasPrivate kelas = new KelasPrivate(42);
//             kelas.TampilkanAngka();
//         }
//     }
// }

// Console.Write("Nothing is impossible. ");
// Console.WriteLine("The word itself says 'I'm possible!");
// Console.WriteLine("-Audrey Hepburn");


using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vini hira dazzle");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int angka1 = int.Parse(input1);
            int angka2 = int.Parse(input2);

            Console.Write(Tes.IniCoba.Penambahan(angka1,angka2));

        }
    }
}