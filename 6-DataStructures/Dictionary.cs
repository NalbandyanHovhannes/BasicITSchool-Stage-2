using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataStructures
{
    class Dictionary
    {
        //The following Dictionary class is a generic class and
        //can store any data type. This class is defined in the
        //code snippet creates a dictionary where both keys and values are string types.

        Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
        public void DictionaryMethod()
        {
            EmployeeList.Add("Mahesh Chand", "Programmer");
            EmployeeList.Add("Praveen Kumar", "Project Manager");
            EmployeeList.Add("Raj Kumar", "Architect");
            EmployeeList.Add("Nipun Tomar", "Asst. Project Manager");
            EmployeeList.Add("Dinesh Beniwal", "Manager");
        }

        Dictionary<string, float> PriceList = new Dictionary<string, float>(3);

        public void FloatMethod()
        {
            PriceList.Add("Tea", 3.25f);
            PriceList.Add("Juice", 2.76f);
            PriceList.Add("Milk", 1.15f);
        }

        public void CreateDictionary()
        {
            // Create a dictionary with string key and Int16 value pair
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Read all data
            Console.WriteLine("Authors List");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }
            Console.WriteLine("Count: {0}", AuthorList.Count);
            /// Set Item value
            AuthorList["Mahesh Chand"] = 20;
            // Get Item value
            //Int16 age = Convert.ToInt16(AuthorList["Mahesh Chand"]);


            // Get the collection of keys of C# Dictionary

            Dictionary<string, Int16>.KeyCollection keys = AuthorList.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            //
            // Get and display values
            // Get the collection of values of a C# Dictionary 
            Dictionary<string, Int16>.ValueCollection values = AuthorList.Values;
            foreach (Int16 val in values)
            {
                Console.WriteLine("Value: {0}", val);
            }


            Dictionary<string, Int16> AuthorList1 = new Dictionary<string, Int16>();
            AuthorList1.Add("Mahesh Chand", 35);
            AuthorList1["Neel Beniwal"] = 9;
            AuthorList1["Mahesh Chand"] = 20;

            //remove
            AuthorList.Remove("Mahesh Chand");
            // Remove all items
            AuthorList.Clear();

            //Find key
            if (!AuthorList.ContainsKey("Mahesh Chand"))
            {
                AuthorList["Mahesh Chand"] = 20;
            }

            //
            if (!AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Item found");
            }
        }

    }
    public class SecondDic
    {
        public void SecondMeth()
        {
            // Create a dictionary with string key and Int16 value pair
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Count
            Console.WriteLine("Count: {0}", AuthorList.Count);
            // Set Item value
            AuthorList["Neel Beniwal"] = 9;
            if (!AuthorList.ContainsKey("Mahesh Chand"))
            {
                AuthorList["Mahesh Chand"] = 20;
            }
            if (!AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Item found");
            }
            // Read all items
            Console.WriteLine("Authors all items:");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }
            // Remove item with key = 'Mahesh Chand'
            AuthorList.Remove("Mahesh Chand");
            // Remove all items
            AuthorList.Clear();
        }
    }
}
