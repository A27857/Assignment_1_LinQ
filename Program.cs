using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Fundamental__2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> members = new List<Student>
        {
            new Student{
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                PhoneNumber="",
                BirthPlace = "Bac Ninh",
                // IsGraduated  = false
            },
            new Student{
                FirstName = "Dat",
                LastName = "Dam Tuan",
                Gender = "Male",
                DateOfBirth = new DateTime(1996,7,14),
                PhoneNumber="",
                BirthPlace = "Ha noi",
                // IsGraduated  = false
            },
            new Student{
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                // IsGraduated  = false
            },
            new Student{
                FirstName = "Van",
                LastName = "Nguyen Cong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,4,5),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                //IsGraduated  = false
            },
            new Student{
                FirstName = "Trang",
                LastName = "Nguyen Huyen",
                Gender = "Female",
                DateOfBirth = new DateTime(2002,7,14),
                PhoneNumber="",
                BirthPlace = "Hai Duong",
                //IsGraduated  = false
            },
            new Student{
                FirstName = "Ky",
                LastName = "Nguyen Khac",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,11,12),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                //IsGraduated  = false
            },
            new Student{
                FirstName = "Phuoc",
                LastName = "Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,11,25),
                PhoneNumber="",
                BirthPlace = "Hai Phong",
                //IsGraduated  = false
            },
            new Student{
                FirstName = "Hung",
                LastName = "Bui",
                Gender = "Male",
                DateOfBirth = new DateTime(1983,11,13),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                // IsGraduated  = false
            }
        };
        Student temp = new Student();
        temp.PrintFirstOldestStudent(members);
        }
    }

}
