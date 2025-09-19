// NAMA FILE: Person.cs
namespace Latihan // Sesuaikan dengan nama proyek Anda
{
    // KONSEP 1: CLASS
    // Ini adalah 'blueprint' atau cetak biru untuk object Person.
    // Class ini akan menjadi class induk (parent class) untuk Inheritance.
    public class Person
    {
        // KONSEP 3: ENCAPSULATION & DATA HIDING
        // Data (_name dan _age) disembunyikan dengan modifier 'private'.
        // Akses ke data ini hanya bisa melalui Properti publik (Name dan Age).
        private string _name;
        private int _age;

        // Properti publik untuk mengakses field private _name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Properti publik untuk mengakses field private _age
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // KONSEP 2: CONSTRUCTOR
        // Constructor adalah method khusus yang dipanggil saat sebuah object dibuat.
        // Gunanya untuk menginisialisasi nilai awal dari properti.
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // KONSEP 5 (POLYMORPHISM - OVERRIDING): Method Virtual
        // 'virtual' mengizinkan method ini untuk di-override (didefinisikan ulang)
        // oleh class turunannya (anaknya).
        public virtual void Introduce()
        {
            Console.WriteLine($"Halo, nama saya {Name}, umur saya {Age} tahun.");
        }
    }
}