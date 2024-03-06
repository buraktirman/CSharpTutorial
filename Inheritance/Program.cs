﻿namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            [
                new Customer
                {
                    FirstName="Engin"
                },
                new Student
                {
                    FirstName="Derin"
                },
                new Person
                {
                    FirstName="Salih"
                }
            ];

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}