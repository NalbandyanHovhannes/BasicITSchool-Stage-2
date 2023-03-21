namespace PolyTest
{
    internal class TestClass:VirtualClass
    {
        public override void VirtualEmptyMethod()
        {
            Console.WriteLine("TestClass: VirtualClass");
           base.VirtualEmptyMethod();
            Console.WriteLine("Ending VirtualEmptyMethod");

        }
        public override int VirtualMethod(int u)
        {
            return base.VirtualMethod( u);
        }
        public TestClass(int t)
        {
            base.VirtualMethod(t);
        }
        public TestClass()
        {

        }
    }
}
