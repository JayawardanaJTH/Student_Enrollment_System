using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Models
{
    class Student
    {
        private int _regno;
        private string _name;
        private DateTime _dob;
        private char _gender;
        private int _contact;
        private string _course;

            public Student(int regno, string name, DateTime dob, char gender, int contact, string course)
        {
            this._regno = regno;
            this._name = name;
            this._dob = dob;
            this._gender = gender;
            this._contact = contact;
            this._course = course;
        }

        public int regno
        {
            get { return _regno; }
            set { _regno = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public char gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public string course
        {
            get { return _course; }
            set { _course = value; }
        }
    }
}
