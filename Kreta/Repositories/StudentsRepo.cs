using Kreta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Repositories
{
    public class StudentsRepo
    {
        private List<Student> students;
        public List<Student> Studentss { get => students; }

        public StudentsRepo()
        {
            students = new List<Student>();
            MakeTestData();
        }  
        public void MakeTestData()
        {
            students.Add(new Student(1,"Imre Zoltán",2));
            students.Add(new Student(2,"Nagy Anna",1));
            students.Add(new Student(3,"Kis Imre",3));
        }
    }
}
