using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Linq;

namespace C__Fundamental__2
{
    public class Student : Person
    {
        public bool IsGraduated { set; get; }
        Student temp = new Student();
        public void ImportClass()
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Enter student number: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Student {0}: ", i + 1);
                Student temp = new Student();
                temp.ImportStudent();
                students.Add(temp);
            }
        }
        public void PrintFirstStudentByBirthPlace(List<Student> students, string location)
        {
            var result = students.Where(st => st.BirthPlace.Equals(location, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            System.Console.WriteLine("Student was born {0} is: ", location);
            if (result != null)
            {
                result.ExportStudent();
            }
            else
            {
                System.Console.WriteLine($"There are no students in {location}!");
            }
            // var result = from item in students where item.BirthPlace == location select item;
            // foreach (var item in result)
            // {
            //     BirthPlaceHN.Add(item);
            // }
        }
        public void PrintFullNameOfStudents(List<Student> students)
        {
            var result = students.Select(st => $"{st.FirstName} {st.LastName}").ToList();
            System.Console.WriteLine(result);
        }
        public void PrintMaleStudent(List<Student> students)
        {
            var result = students.Where(st => st.Gender == "Male").ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    item.ExportStudent();
                }
            }
            else
            {
                System.Console.WriteLine("Don't have student is Male!");
            }
        }
        public void PrintListStudentsByBirthYear(List<Student> students, int year)
        {
            var List1 = students.Where(st => st.DateOfBirth.Year == year).ToList();
            var List2 = students.Where(st => st.DateOfBirth.Year > year).ToList();
            var List3 = students.Where(st => st.DateOfBirth.Year < year).ToList();
            if (List1 != null)
            {
                System.Console.WriteLine($"List of members who has birth year is {year}:");
                foreach (var item in List1)
                {
                    item.ExportStudent();
                }
            }
            else
            {
                System.Console.WriteLine($"There are no students born in {year}!");
            }
            if (List2 != null)
            {
                System.Console.WriteLine($"List of members who has birth year is {year}:");
                foreach (var item in List2)
                {
                    item.ExportStudent();
                }
            }
            else
            {
                System.Console.WriteLine($"There are no students born in {year}!");
            }
            if (List3 != null)
            {
                System.Console.WriteLine($"List of members who has birth year is {year}:");
                foreach (var item in List3)
                {
                    item.ExportStudent();
                }
            }
            else
            {
                System.Console.WriteLine($"There are no students born in {year}!");
            }
        }
        public void PrintFirstOldestStudent(List<Student> students)
        {
            var biggest = students.Max(st => st.Age);
            System.Console.WriteLine(biggest);
            var oldest = students.Where(st => st.Age == biggest).ToList();
            var oldestTemp = oldest.FirstOrDefault();
            oldestTemp.ExportStudent();
            // if(oldestTemp!=null)
            // {
            //     foreach (var item in oldestTemp)
            //     {
            //         item.ExportStudent();
            //     }
            // }
            // var biggest = students.Aggregate((i1, i2) => i1.Age > i2.Age ? i1 : i2);
            // biggest.ExportStudent();
        }
        public void ImportStudent()
        {
            Console.Write("FirstName is: \n");
            FirstName = Console.ReadLine();

            Console.Write("LastName is: \n");
            LastName = Console.ReadLine();

            Console.Write("Gender is: \n");
            Gender = Console.ReadLine();

            Console.Write("BirthPlace is: \n");
            BirthPlace = Console.ReadLine();

            Console.Write("PhoneNumber is: \n");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the form: Year, Month, Day");
            Console.Write("DateOfBirth is: \n");
            DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Age is: \n");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void ExportStudent()
        {
            Console.WriteLine("FirstName: {0} || LastName: {1} || Gender: {2} || BirthPlace: || {3} || DateOfBirth: {4} || Age: {5}", FirstName, LastName, Gender, BirthPlace, DateOfBirth, Age);
        }
    }
}