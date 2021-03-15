using System;

namespace Constructors
{

    class Student
    {
        int pin;
        string name;

        // // default constructor
        // Student()
        // {
        //     pin = 111;
        //     name = "vedhanth";
        // }

        // parameterized constructor
        Student(int p, string n)
        {
            pin = p;
            name = n;
        }

        // copy constructor
        Student(Student s)
        {
            pin = s.pin;
            name = s.name;
        }

        static void Main(string[] args)
        {

            Student v1 = new Student(111, "vedhanth");
            Student v2 = new Student(v1);

            Console.WriteLine(v1.pin);
            Console.WriteLine(v2.pin);

        }
    }

}
