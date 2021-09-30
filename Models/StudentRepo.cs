using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutFromDoc.Models
{

    public class StudentRepo
    {
        public static List<Student> studentList = new List<Student>();
        //{
        //    new Student(){StudentId=1, Age=23, StudentName="Raj"},
        //    new Student(){StudentId=2, Age=22, StudentName="Rajesh"},
        //    new Student(){StudentId=1, Age=24, StudentName="Raju"},

        //};
        
        public StudentRepo()
        {
            Student s1 = new Student(1, "Raj", 23);
            studentList.Add(s1);
            Student s2 = new Student(2, "Rajesh", 25);
            studentList.Add(s1);
            Student s3 = new Student(1, "Raju", 22);
            studentList.Add(s1);
        }
        public Student getStudentById(int id)
        {
            foreach(Student temp in studentList )
            {
                if(temp.StudentId==id)
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