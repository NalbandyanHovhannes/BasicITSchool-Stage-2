



List<string> Names = new List<string>() { "Khachik", "Vachik", 
                                                "Qajik", "Gurgen", "Davit"};

var newList = Names.FindAll(x => x.ToLower().EndsWith("ik") 
                                || x.StartsWith("D") 
                                   && x.Length > 5);
foreach(var name in newList)
{
    Console.WriteLine(name);
}

