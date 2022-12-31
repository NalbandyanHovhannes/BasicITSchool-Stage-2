// See https://aka.ms/new-console-template for more information
using RecordExample1;

Person a = new Person("Gor");
Person b = new Person("Gor");
Console.WriteLine("ReferenceEquals(a, b) = {0}",
                                Object.ReferenceEquals(a, b));
string c = "a";
string d = "a";
Console.WriteLine("ReferenceEquals(c, d) = {0}",
                                Object.ReferenceEquals(c, d));
Console.WriteLine(a==b);
Console.WriteLine(a);
record class Person(string Name);
record RecordTest();

