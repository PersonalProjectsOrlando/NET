using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2 {
    class Test {
        static void Main(string[] args)
        {
            Course course = new Course();
            Console.WriteLine("All Students: ");
            course.printStudents();
            Console.WriteLine("Approved  Students: ");
            course.printYes((note) => note>=3);
            Console.WriteLine("Students note =2 : ");
            course.printYes((note) => note==2);
        }
    }
    class Student {
        public Student(string name, double note) {
            Name = name;
            Note = note;
        }
        public Student(){}
        public string Name { set; get; }
        public double Note { set;get; }
    }
    class Course {
        Student[] student = new Student[5];
        public delegate bool Comparation(double element);
        public Course() {
            student[0] = new Student("Orlando", 5.0);
            student[1] = new Student("ALfredo", 3.0);
            student[2] = new Student("Barragan", 2.0);
            student[3] = new Student("Malaver", 2.7);
            student[4] = new Student("Jaime", 1.0);

        }
        public void printStudents() {
            foreach (Student student in student) { 
                Console.WriteLine($"Name: {student.Name} - Note: {student.Note}");
            }
        }
        public void printYes(Comparation comparation) {
            foreach (var student in student) {
                if (comparation(student.Note)) {
                    Console.WriteLine($"Name: {student.Name} - Note: {student.Note}");

                }
            }
        }
        
    }

}