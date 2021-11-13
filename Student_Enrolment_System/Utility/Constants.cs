using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Utility
{
    class Constants
    {
        public const string InsertStudent = "INSERT INTO student (Registration_Number, Student_Name, Date_of_Birth, Gender, Contact_Number, Course_enrolled_in) VALUES (@regno,@name,@dob,@gender,@contact,@course)";
        public const string GetStudentByRegno = "SELECT * FROM student WHERE Registration_Number = @regno";
        public const string DeleteStudentByRegno = "DELETE FROM student WHERE Registration_Number = @regno";
        public const string GetAllStudentsRegistrationNumbers = "SELECT Registration_Number FROM student";
        public const string InsertCourseFee = "INSERT INTO course_fee(Registration_Number, Amount, Discount, Total) VALUES (@regno, @amount, @discount, @total)";
    }
}
