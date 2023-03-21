namespace NoteBookMarket
{
    internal interface INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
         int count { get; set; }

        public void FirstAccelaration();//Required
        public void First2Accelaration() { }//Optional

        public void SecondAccelaration(int t)//Optional
        {
            Console.WriteLine(t);
        }

    }
}
