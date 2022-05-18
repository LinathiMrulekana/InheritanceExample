using System;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Person("Linda",30 ,"784598492",GenderEnum.female );

            Student student = new Student("Allan", 22, "376436", "6235329", GenderEnum.nonBinarry);
            
            Console.WriteLine("Student Name: "+ student.Name);
            Console.WriteLine("Student Number: " + student.StudentNumber);

            Console.WriteLine("Employee name: "+ employee.Name);
          //  Console.WriteLine("Employee Number: "+ employee.StudentNumber);

           Console.WriteLine("Can do Future Lab: "+ student.IsEligibleForFutureLAB());



        }
    }
}
