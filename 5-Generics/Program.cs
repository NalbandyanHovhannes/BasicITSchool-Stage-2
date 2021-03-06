using System;

namespace _5_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Examples ex = new Examples();
            ex.Adding(9);
            ex.Adding("8954");
            ex.Adding(8.5);
            //ex.Adding(ex.TestSwap());

           ex.TestSwap();

    
        //instantiate generic with Integer
        TestClass1<int> intObj = new TestClass1<int>();

            //adding integer values into collection
            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);     //No boxing
            intObj.Add(4);
            intObj.Add(5);

            //displaying values
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intObj[i]);   //No unboxing
            }
            Console.ReadKey();

            TestClass1<int> obj = new TestClass1<int>();
            obj.Add(50);    //No boxing
            //int x = obj[0]; // No unboxing


            //Array
            //T<>=new Array()
          
        }
    }
    public class TestClass<T> { }
    public class TestClass1<T>
    {
        // define an Array of Generic type with length 5
        T[] obj = new T[5];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;
        }
        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }


}
            
        