using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Utility
{
    class Constants
    {
        public const string insert_student = "INSERT INTO student (Registration_Number, Student_Name, Date_of_Birth, Gender, Contact_Number, Course_enrolled_in) VALUES (@regno,@name,@dob,@gender,@contact,@course)";
        public const string get_student_by_regno = "SELECT * FROM student WHERE Registration_Number = @regno";
        public const string delete_student_by_regno = "DELETE FROM student WHERE Registration_Number = @regno";
    }
}
