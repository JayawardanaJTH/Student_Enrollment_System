using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Models
{
    class Student
    {
        private int _Regno;
        private string _Name;
        private DateTime _Birthday;
        private char _Gender;
        private int _Contact;
        private string _Course;
        private bool _IsAvailable;

        public Student()
        {
            _IsAvailable = false;
        }

        public Student(int Regno, string Name, DateTime Birthday, char Gender, int Contact, string Course)
        {
            this._Regno = Regno;
            this._Name = Name;
            this._Birthday = Birthday;
            this._Gender = Gender;
            this._Contact = Contact;
            this._Course = Course;
        }

        public int Regno
        {
            get { return _Regno; }
            set { _Regno = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public int Contact
        {
            get { return _Contact; }
            set { _Contact = value; }
        }

        public string Course
        {
            get { return _Course; }
            set { _Course = value; }
        }

        public bool Status
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }
    }
}
