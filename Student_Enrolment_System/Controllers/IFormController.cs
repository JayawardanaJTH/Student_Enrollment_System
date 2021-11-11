using Student_Enrolment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Controllers
{
    interface IFormController
    {
        /** <summary>This is for get the age
          (<paramref name="Birthday"/>)
            .</summary>
        */
        int GetAge(DateTime Birthday);

        /**
            <summary>This is for validate the form
            (<paramref name="ST_Enroll_UI_object"/>)</summary>
        */
        bool ValidatForm(object Object);

        //----Database handling methods----

        /**
            <summary>This is for insert Student details to database.
            (<paramref name="Student"/>)</summary>
        */
        bool InsertStudent(Student Student);

        /**
            <summary>This is for find Student is exist or not in the database.
            (<paramref name="Registration_Number"/>)</summary>
        */
        Student FindStudentByRegno(int RegNo);

        /**
            <summary>This is for delte Student.
            (<paramref name="Registration_Number"/>)</summary>
        */
        bool DeleteStudentByRegno(int RegNo);
    }
}
