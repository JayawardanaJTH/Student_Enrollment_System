using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Models
{
    class Student
    {
        private int regno { get; set; }
        private string name { get; set; }
        private DateTime dob { get; set; }
        private char gender { get; set; }
        private int contact { get; set; }
        private string course { get; set; }

        public Student(int regno, string name, DateTime dob, char gender, int contact, string course)
        {
            this.regno = regno;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.contact = contact;
            this.course = course;
        }
    }
}
