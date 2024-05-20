// See https://aka.ms/new-console-template for more information
using System.Collections;

//IDictionary<int,string> numbers=new Dictionary<int,string>();
//numbers.Add(1,"nimur");
//numbers.Add(2,null);

//foreach(KeyValuePair<int,string> kvp in numbers)
//    Console.WriteLine("key: {0}, value: {1}", kvp.Key,kvp.Value);

var citys = new Dictionary<string, string>()
{
    {"UK","London"},
    {"Bd" ,"Bangladesh"}
};
//Console.WriteLine(citys["UK"]);

if (citys.ContainsKey("France"))
{
    Console.WriteLine(citys["France"]);
}
else
    Console.WriteLine("not found");

string result;
if(citys.TryGetValue("Uk",out result))
{
    Console.WriteLine(result);
}

//foreach (var kvp in citys)
//{
//    Console.WriteLine("key: {0}   value: {1}",kvp.Key,kvp.Value);
//}