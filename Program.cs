// NAMA FILE: Program.cs (Versi Interaktif)
namespace Latihan // Sesuaikan dengan nama proyek Anda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di Sistem Pendaftaran Kursus Sederhana!");
            Console.WriteLine("====================================================\n");

            // =================================================================
            // BAGIAN 1: INPUT DATA GURU DARI PENGGUNA
            // =================================================================
            Console.WriteLine("--- Pendaftaran Guru ---");
            Console.Write("Masukkan Nama Guru: ");
            string teacherName = Console.ReadLine();

            Console.Write("Masukkan Umur Guru (angka): ");
            int teacherAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan NIP Guru: ");
            string teacherID = Console.ReadLine();

            // Membuat object Teacher dari input pengguna
            Teacher teacher1 = new Teacher(teacherName, teacherAge, teacherID);
            Console.WriteLine("-> Data Guru berhasil dibuat!\n");


            // =================================================================
            // BAGIAN 2: INPUT DATA SISWA DARI PENGGUNA
            // =================================================================
            Console.WriteLine("--- Pendaftaran Siswa ---");
            Console.Write("Masukkan Nama Siswa: ");
            string studentName = Console.ReadLine();

            Console.Write("Masukkan Umur Siswa (angka): ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan ID Siswa: ");
            string studentID = Console.ReadLine();

            // Membuat object Student dari input pengguna
            Student student1 = new Student(studentName, studentAge, studentID);
            Console.WriteLine("-> Data Siswa berhasil dibuat!\n");


            // =================================================================
            // BAGIAN 3: INPUT DATA MATA KULIAH DARI PENGGUNA
            // =================================================================
            Console.WriteLine("--- Pembuatan Mata Kuliah ---");
            Console.Write("Masukkan Nama Mata Kuliah: ");
            string courseName = Console.ReadLine();

            // Membuat object Course menggunakan guru yang sudah dibuat sebelumnya (Composition)
            Course oopCourse = new Course(courseName, teacher1);
            Console.WriteLine("-> Mata Kuliah berhasil dibuat!\n");


            // =================================================================
            // BAGIAN 4: MENAMPILKAN HASIL & DEMONSTRASI KONSEP OOP
            // =================================================================
            Console.WriteLine("\n====================================================");
            Console.WriteLine("HASIL PENDAFTARAN & DEMONSTRASI KONSEP OOP");
            Console.WriteLine("====================================================\n");

            // KONSEP 5 (POLYMORPHISM - OVERRIDING)
            Console.WriteLine("--- Demonstrasi Polymorphism (Overriding) ---");
            teacher1.Introduce();
            Console.WriteLine();
            student1.Introduce();
            Console.WriteLine("\n");

            // KONSEP 5 (POLYMORPHISM - OVERLOADING)
            Console.WriteLine("--- Demonstrasi Polymorphism (Overloading) ---");
            student1.SubmitAssignment();
            student1.SubmitAssignment(oopCourse.CourseName); // Menggunakan nama kursus dari input
            Console.WriteLine("\n");

            // KONSEP 6: COMPOSITION
            Console.WriteLine("--- Demonstrasi Composition ---");
            oopCourse.DisplayCourseInfo();
            Console.WriteLine("\n");

            // KONSEP 3: ENCAPSULATION
            Console.WriteLine("--- Demonstrasi Encapsulation ---");
            Console.WriteLine($"Mengakses data siswa melalui properti publik: {student1.Name}");

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}