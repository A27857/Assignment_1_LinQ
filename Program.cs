using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Fundamental__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Student> StudentList = new List<Student>(){
            //             new Student(){FirstName="Ngo", LastName="Duy",Gender="Male",DateOfBirth=new DateTime(2001,9,15),PhoneNumber= "0389232053",BirthPlace="Thai Nguyen", Age=22, IsGraduated=true },
            //             new Student(){FirstName="Dam", LastName="Dat",Gender="Male",DateOfBirth=new DateTime(1996,9,15),PhoneNumber="0389232053",BirthPlace="Ha Noi", Age=25,IsGraduated=true },
            //             new Student(){FirstName="Nguyen", LastName="Duy",Gender="Female",DateOfBirth=new DateTime(2000,9,15),PhoneNumber="0389232053",BirthPlace="Ha Noi", Age=21,IsGraduated=true },
            //             };
            //Console.WriteLine("Hello World!");
            List<Student> students = new List<Student>();
            Student temp = new Student();
            temp.ImportClass();
            students.Add(temp);
            temp.PrintFirstStudentByBirthPlace(students, "Ha Noi");
            temp.PrintFirstOldestStudent(students);
            temp.PrintFullNameOfStudents(students);
            temp.PrintListStudentsByBirthYear(students, 2000);
        }
        
         
    }
    
}
