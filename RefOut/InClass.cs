using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    public class InClass
    {
        //The in modifier is most often used for performance reasons and was introduced in
        //C# 7.2. The motivation of in is to be used with a struct to improve
        //performance by declaring that the
        //value will not be modified. When using with reference types,
        //it only prevents you from assigning a new reference.'''


        public void EnrollIN(in StudentIN studentIN)
        {
            // With in assigning a new object would throw an error
            // student = new Student();

            // We can still do this with reference types though
            studentIN.Enrolled = true;
        }

    }

    public class StudentIN
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}

