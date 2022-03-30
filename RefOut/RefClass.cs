using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class RefClass
    {

        public  void Enroll(ref Student student,ref int t)
        {
            // With ref, all three lines below alter the student
            // variable outside the method.
            student.Enrolled = true;
            //student = new Student();
            student.Enrolled = true;
        }
        public int IncrementExample(ref int num)
        {
             num = num + 1;
            return num;
        }
        public int IncrementExample2( int num2)
        {
            num2 = num2 + 1;
            return num2;
        }

    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
    

   
}
