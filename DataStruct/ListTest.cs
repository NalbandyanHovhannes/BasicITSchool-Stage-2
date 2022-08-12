namespace DataStruct
{
    internal class ListTest
    {
        public static void PrintList()
        {
            List<int> listtest=new List<int>();
            listtest.Add(1);
            listtest.Add(2);    
            listtest.Add(3);    
            listtest.Add(4);    
            listtest.Add(5);
            foreach (var item in listtest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
