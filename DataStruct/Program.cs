

using DataStruct;

QueueTest.PrintQueue();
StackTest.PrintStack();
ListTest.PrintList();
LinkedListTest.PrintLinkedList();
DictionaryTest.PrintDictionary();
HashSetTest.PrintHashSet();







//------------------------------------------------------

//Stack<int> stack = new Stack<int>();
//stack.Push(1);
//stack.Push(2);

//while (stack.Count > 0)
//{
//    int a = stack.Pop();
//    Console.WriteLine(a);
//}

////------------------------------------------------------
//Queue<int> queue = new Queue<int>();
//queue.Enqueue(100);//like add meth
//queue.Enqueue(200);
//queue.Enqueue(300);


////while (queue.Count > 0)
////{
////    int a = queue.Peek();

////    Console.WriteLine(a);
////}
//foreach (var item in queue)
//{
//    //int a = queue.Peek();

//    Console.WriteLine(item);
//}

//------------------------------------------------------

LinkedList<int> linkedlist = new LinkedList<int>();
linkedlist.AddLast(100);
linkedlist.AddLast(200);
linkedlist.AddLast(300);
linkedlist.AddLast(400);
linkedlist.AddLast(500);
linkedlist.AddFirst(001);
foreach (var item in linkedlist)
{
    Console.WriteLine(item);
}
//------------------------------------------------------
List<int> list = new List<int>();

list.Add(100);
list.Add(200);
list.Insert(0, 300);
list.Remove(200);
//list.RemoveAt(2);
list.Clear();
foreach (var item in list)
{
    Console.WriteLine(item);
}
//------------------------------------------------------
//---------key,Value
Dictionary<int, int> dict = new Dictionary<int, int>();
Dictionary<string, int> dict1 = new Dictionary<string, int>();
Dictionary<string, string> dict2 = new Dictionary<string, string>();
dict.Add(100, 200);
dict.Add(200, 300);
dict.Add(300, 400);
dict.Add(400, 500);
Console.WriteLine(dict[3]);
dict2.Add("PlayerNotFound","PLNF");

//-------------------------------------
HashSet<string> set = new HashSet<string>()
{
    "8",
    "88",
    "888",
    "8", 
    //dublicate removed
};
set.Add("99");
foreach (var item in set)
{
    Console.WriteLine(item);
}

HashSet<string> set2 = new HashSet<string>()
{
    "8",
    "88",
    "888",
    "8", 
    //dublicate removed
};
set.UnionWith(set2);
set.ExceptWith(set2);



