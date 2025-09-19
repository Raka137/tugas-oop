// NAMA FILE: Course.cs
namespace Latihan // Sesuaikan dengan nama proyek Anda
{
    public class Course
    {
        public string CourseName { get; set; }

        // KONSEP 6: COMPOSITION
        // Class 'Course' MEMILIKI sebuah object 'Teacher'.
        // Ini adalah hubungan "has-a" (memiliki). Course "has-a" Teacher.
        // Berbeda dengan inheritance yang merupakan hubungan "is-a" (adalah).
        public Teacher CourseTeacher { get; set; }

        public Course(string courseName, Teacher teacher)
        {
            this.CourseName = courseName;
            this.CourseTeacher = teacher;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Nama Mata Kuliah: {CourseName}");
            // Mengakses properti dari object Teacher yang dimilikinya
            Console.WriteLine($"Dosen Pengajar: {CourseTeacher.Name}");
        }
    }
}