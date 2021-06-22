using System;
namespace C__Fundamental__2
{
    public class Person
    {
            public string FirstName {get;set;}
            public string LastName {get;set;}
            public string Gender {get;set;}
            public string BirthPlace {get;set;}
            public string PhoneNumber {get;set;}
            public int Age {get;set;}
            //private string _fullname;
            public DateTime DateOfBirth;

            // public string FullName
            // {
            //     get 
            //     {
            //     string v = LastName + FirstName;
            //     return v;
            //     }
            //     set
            //     {
            //         _fullname = value;
            //     }
            // }     
    }
}