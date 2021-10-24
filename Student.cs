using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App
{
    class Student 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Point { get; set; }
        public  int Average { get; set; }
        private static int count;
        public readonly int Id;
            
        private Student()
        {
            count++;
            Id = count;
        }

        public Student(string name, string surname, int point,int average) : this()
        {
            Name = name;
            Surname = surname;
            Point = point;
            Average = average;
        }

        public override string ToString()
        {
            return $"Student:{Id} - Name:{Name} Point:{Point} Average:{Average}";

        }
    //    public override bool Equals(object obj)
    //    {
    //        return 
    //    }

    }
}
