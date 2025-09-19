// NAMA FILE: Teacher.cs
namespace Latihan // Sesuaikan dengan nama proyek Anda
{
    // KONSEP 4: INHERITANCE (PEWARISAN)
    // Class 'Teacher' juga mewarisi dari class 'Person'.
    public class Teacher : Person
    {
        public string EmployeeID { get; set; }

        public Teacher(string name, int age, string employeeID) : base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        // KONSEP 5 (POLYMORPHISM - OVERRIDING)
        // Meng-override method Introduce khusus untuk Teacher.
        public override void Introduce()
        {
            Console.WriteLine($"Selamat pagi, saya {Name}, umur saya {Age} tahun.");
            Console.WriteLine($"Saya adalah seorang guru dengan NIP: {EmployeeID}.");
        }
    }
}