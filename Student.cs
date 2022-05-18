using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Student : Person
    {
        private string _studentNumber;
      

        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }


        public Student(string name, int age, string idnumber,string studentNumber, GenderEnum gender) : base(name, age, idnumber, gender)
        {
            _studentNumber = studentNumber;
        }

        public bool IsEligibleForFutureLAB()
        {
            if ( _Age > 18 && _Age < 35)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
