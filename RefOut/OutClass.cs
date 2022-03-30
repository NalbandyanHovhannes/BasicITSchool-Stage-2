namespace RefOut
{
    class OutClass
    {
        public void EnrollOut(out StudentOut studentOut)
        {
            //We need to initialize the variable in the method before we can do anything
            studentOut = new StudentOut();
            studentOut.Enrolled = false;
        }
    }

    public class StudentOut
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}

