using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Inheritance
{
    public class HumanBase
    {
        public HumanBase()
        {

        }
        public HumanBase(short age)
        {
            Console.WriteLine(age.ToString()+   "   age");
            Age= age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public GenderEnum Gender { get; set; }
        private string Test { get; set; }

        //public void publicHelloMen()
        //{ 
        //    Console.WriteLine(" public Barev Mard");
        //}
        //internal void internalByMen()
        //{
        //    Console.WriteLine(" internal ByMen");
        //}
        //protected void protectedWhyMen()
        //{
        //    Console.WriteLine("protected WhyMen");
        //}
        //private void _privateWhyMen()
        //{
        //    Console.WriteLine("protected WhyMen");
        //}
    }
    public enum GenderEnum
    {
        Boy,
        Girl,
        Esiminch
    }
}
