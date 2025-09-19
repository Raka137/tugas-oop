// NAMA FILE: Student.cs
namespace Latihan // Sesuaikan dengan nama proyek Anda
{
    // KONSEP 4: INHERITANCE (PEWARISAN)
    // Class 'Student' mewarisi semua properti dan method publik dari class 'Person'.
    // Ini ditandai dengan tanda titik dua (: Person).
    public class Student : Person
    {
        public string StudentID { get; set; }

        // Constructor untuk Student.
        // ': base(name, age)' memanggil constructor dari class induk (Person) terlebih dahulu.
        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.StudentID = studentID;
        }

        // KONSEP 5 (POLYMORPHISM - OVERRIDING)
        // Method 'Introduce' ini meng-override method 'Introduce' dari class Person.
        // Perilakunya diubah khusus untuk Student.
        public override void Introduce()
        {
            // Memanggil method Introduce() dari base class terlebih dahulu.
            base.Introduce();
            Console.WriteLine($"Saya adalah seorang siswa dengan ID: {StudentID}.");
        }

        // KONSEP 5 (POLYMORPHISM - OVERLOADING)
        // Dua method dengan nama sama (SubmitAssignment) tetapi parameter berbeda.

        // Versi 1: Tanpa parameter
        public void SubmitAssignment()
        {
            Console.WriteLine("Tugas telah dikumpulkan.");
        }

        // Versi 2: Dengan parameter nama kursus
        public void SubmitAssignment(string courseName)
        {
            Console.WriteLine($"Tugas untuk mata kuliah {courseName} telah dikumpulkan.");
        }
    }
}