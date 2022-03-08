namespace _2_Inheritance
{
    public class BaseClass
    {
        public int date;
        public int engineLitr;
        public decimal CalcTax(int date,decimal marketPrice)
        {
            return date < 7 ? marketPrice / 10 : marketPrice / 2;
        }
        public BaseClass()
        {
        }
    }
}

