using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutFromDoc.Models
{

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            this.StudentId = id;
            this.Age = age;
            this.StudentName = name;
        }
        public List<Student> studentList = new List<Student>();
        //{
        //    new Student(){StudentId=1, Age=23, StudentName="Raj"},
        //    new Student(){StudentId=2, Age=22, StudentName="Rajesh"},
        //    new Student(){StudentId=1, Age=24, StudentName="Raju"},

        //};



        public Student getStudentById(int id)
        {
            foreach (Student temp in studentList)
            {
                if (temp.StudentId == id)
                    return temp;
            }
            throw new Exception("id not found");
        }
        public IList<Student> getStudentList()
        {
            return studentList;
        }
    }
}

