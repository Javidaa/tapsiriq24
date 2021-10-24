using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App
{
    class Group
    {

        public string Groupname { get; set; }
        public int MaxStudentCount { get; set; }
        private List <Student> Students { get; set; }
        
        public int Average {
            get {
                int result = 0;
                foreach (Student item in Students)
                {
                    result += item.Average;

                }
                return result;
            }
        }

        private static int count;
        public readonly int Id;
        private Group()
        {
            count++;
            Id = count;
            Students = List<Student>(); 
        }

      public Group(string groupname,int maxStudentCount):this()
      {
            Groupname = groupname;
            MaxStudentCount = maxStudentCount;
      }

        public override string ToString()
        {
            return $"Group: {Id} - Groupname;{Groupname} MaxStudentCount:{MaxStudentCount}";

        }

        public override bool Equals(object obj)
        {
            return Groupname == ((Group)obj).Groupname;
        }

        public bool AddStudent(Student student)
        { 
            if (!Students.Contains(student))
            {
                Students.Add(student);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool RemoveStudent(int id)
        {
            int count = Students.Count;
            for (int i = 0; i < count; i++)
            {
                if(Students[i].Id==id)
                {
                    Students.RemoveAt(i);
                    return true;
                }
                
            }
            return false;
        }
        public void PrintAllStudents()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine($"{Groupname}-daki {item}");
            }
        }

        public void SearchAndPrintStudents(string query)
        {
            bool resultFond = false;
            foreach (Student item in Students)
            {
                if (item.Name.Contains(query) || item.Surname.Contains(query))
                {
                    Console.WriteLine($"{item} in {Groupname}");
                    resultFond = true;
                }
            }
            if(!resultFond)
            {
                Console.WriteLine($"No results found in {Groupname}.");
            }
        }
    }

}



