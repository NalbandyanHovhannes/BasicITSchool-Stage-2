using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            RefClass refclass = new RefClass();
            refclass.Enroll(ref student);


            int num = 1;
            refclass.IncrementExample(ref num);
            // num is now 2

            // student.Name is now null since a value was not passed when declaring new Student() in the Enroll method
            // student.Enrolled is now false due to the ref modifier

            //--------------------------------------------------OUT-----------------------
            StudentOut studentOut;

            OutClass outClass = new OutClass();
            outClass.EnrollOut(out studentOut);
            // student will be equal to the value in Enroll. Name will be null and Enrolled will be false.


            //OUT with value types 
            int x;
            Int32.TryParse("3", out x);


            //-------------IN
            var studentIN = new StudentIN
            {
                Name = "Susan",
                Enrolled = false
            };
            InClass inClass = new InClass();
            inClass.EnrollIN(studentIN);
        }
    }
}
