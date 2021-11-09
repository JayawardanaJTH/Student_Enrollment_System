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
          (<paramref name="birthday"/>)
            .</summary>
        */
        int get_age(DateTime dob);

        /**
            <summary>This is for validate the form
            (<paramref name="ST_Enroll_UI_object"/>)</summary>
        */
        bool validate_form(object obj);
    }
}
