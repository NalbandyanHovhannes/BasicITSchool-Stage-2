namespace _2_Inheritance
{
    internal class Doctor:HumanBase
    {
        public short y;
        public short v;
        public void Testmethod()
        {
            Name = "Elizaveta Vachaganovna";     
            Age = y;
            //publicHelloMen();
            //internalByMen();
            //protectedWhyMen();
            ////_privateWhyMen()

        }
        public Doctor():base()
        {

        }
        public Doctor(short t):base( t)
        {
            this.y = t;
            //this.v = base.Age;
        }
    }
}
