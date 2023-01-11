using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    internal class Student

    {
        public string Student_id { get; set; }
        public string Name { get; set; }
        public string Yeardate { get; set; }
        public int Height { get; set; }
        public double Grade { get; set; }
        public string Branch { get; set; }

        public Student(string name, string student_id, string yeardate, int height, double grade, string branch) {
            this.Name = name;
            this.Student_id = student_id;
            this.Yeardate = yeardate;
            this.Height = height;
            this.Grade = grade;
            this.Branch = branch;
        }
    }
}
