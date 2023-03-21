namespace NoteBookMarket
{
    internal class EriksNotebook : INotebook
    {
        public string Brand { get { return Brand; } set { value = "65151"; }}
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAccelaration()
        {
            Console.WriteLine("Brand  " + Brand);
            Console.WriteLine(" EriksNotebook : INotebook++  FirstAccelaration");
        }
         void INotebook.SecondAccelaration(int u) { }

        public int SecondAccelaration()
        { return 0; }

    }
}
