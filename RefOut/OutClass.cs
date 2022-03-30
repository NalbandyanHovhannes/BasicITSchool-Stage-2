namespace RefOut
{
    class OutClass
    {
        public void EnrollOut(out int t,out StudentOut studentOut)
        {
            t = 0;
            //We need to initialize the variable
            //in the method before we can do anything
            studentOut = new StudentOut();
            studentOut.Enrolled = true;
        }
    }

    public class StudentOut
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}

