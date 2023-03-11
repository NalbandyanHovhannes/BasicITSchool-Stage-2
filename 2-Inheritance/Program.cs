using System;


namespace _2_Inheritance
{

 
    class Program
    {
        static void Main(string[] args)
        {                 
            //Doctor doctor = new Doctor();
            //doctor.Testmethod();
            //Console.WriteLine(  doctor.Age+ "Doctor");
            //HumanBase humanBase = new HumanBase();
            //Console.WriteLine(humanBase.Age+ "HumanBase");
            //-------------------------------------------
            Doctor doctorParam = new Doctor(8);
            doctorParam.Testmethod();
            var t=doctorParam.Age;
            Console.WriteLine(doctorParam.Age + "doctorParam");
            HumanBase human=new HumanBase();
            Console.WriteLine(   human.Age); ;
            //HumanBase humanBaseParam = new HumanBase(9);
            //Console.WriteLine(humanBaseParam.Age + "HumanBase");
            DoctorAssistant doctorAssistant= new DoctorAssistant();
            doctorAssistant._DoctorAssist();         
            Console.WriteLine();
        }
    }
}
