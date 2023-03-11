using System;

namespace _2_Inheritance
{
    internal class DoctorAssistant:Doctor
    {
        public void _DoctorAssist()
        {
            Console.WriteLine(Name);
        }
        public short  AssistantAge { get; set; }
        public DoctorAssistant()
        {

        }

    }
}
