using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudent
{
    internal class TestClass
    {

        delegate void SellProduct(string customer);
        delegate int Invoice(int quantity);
        delegate string ChangeString(in string name);

        static void Main(string[] args)
        {
            Product bestseller = new Product(800);

            SellProduct order = new SellProduct(bestseller.Sell);
            order += bestseller.Provide;

            order.Invoke("Gohar");

            Invoice purchase = new Invoice(bestseller.GetFromStock);
            purchase += bestseller.Invoice;

            Console.WriteLine(purchase.Invoke(bestseller.Invoice(7)));

            ChangeString str_update = new ChangeString(SpaceToDot);
            string str = "Gohar Ghazaryan";

            Console.WriteLine(str_update("Gohar Ghazaryan"));

            str_update += RemoveSpace;

            Console.WriteLine(str_update("Gohar Ghazaryan"));

            str_update += ReverseString;

            Console.WriteLine(str_update(in str));




        }

        public static string SpaceToDot(in string a)
        {
            return a.Replace(" ", ".");

        }
        public static string RemoveSpace(in string a)
        {
            return a.Replace(" ", "");

        }
        public static string ReverseString(in string a)
        {
            string temp = "";

            for (int i = a.Length - 1, j = 0; i >= 0; i--, j++)
            {
                temp += a[i];
            }
            return temp;
        }

    }
    public class Product
    {
        int price;
        int quantity;

        public Product(int price)
        {
            this.price = price;
        }


        public void Sell(string customer)
        {
            Console.WriteLine(customer + " buyes product");

        }
        public void Provide(string customer)
        {
            Console.WriteLine("Product is provided to " + customer);

        }

        public int GetFromStock(int qty)
        {
            quantity = qty;
            return quantity;
        }

        public int Invoice(int qty)
        {
            quantity = qty;
            int total = quantity * price;
            return total;
        }
    }
}
