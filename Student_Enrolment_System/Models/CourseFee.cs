using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrolment_System.Models
{
    class CourseFee
    {
        private int _RegistrationNumber;
        private double _Amount;
        private double _Discount;
        private double _Total;

        public CourseFee(int RegistrationNumber, double Amount, double Discount, double Total)
        {
            this._RegistrationNumber = RegistrationNumber;
            this._Amount = Amount;
            this._Discount = Discount;
            this._Total = Total;
        }

        public int RegistrationNumber
        {
            get { return _RegistrationNumber; }
            set { _RegistrationNumber = value; }
        }

        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public double Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        public double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
    }
}
