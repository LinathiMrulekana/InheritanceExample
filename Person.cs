using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Person
    {
       private string _Name;
       protected int _Age;    //accessable to every class
       private string _idNumber;
       private GenderEnum _Gender;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
     
        public int Age
        {
            get { return _Age; }
            set { _Age= value; }
        }
       

        public string IDnumber
        {
            get { return _idNumber; }
            set { _idNumber= value; }
        }

     

        public GenderEnum Gender

        {
            get { return _Gender; }
            set { _Gender= value; }
        }



        //constructor
        public Person(string name, int age, string idnumber, GenderEnum gender)
        {
            _Name = name;
            _Age = age;
            _idNumber = idnumber;
            _Gender = gender;
        }

    }
}
