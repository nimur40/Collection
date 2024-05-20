// See https://aka.ms/new-console-template for more information
using System.Collections;

Hashtable hashtable = new Hashtable();
hashtable.Add(2, "nimur");
hashtable.Add(3,5);

foreach(var i in hashtable.Values)
{
    Console.WriteLine(i);
}

var cities = new Hashtable(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

string citiesOfUK = (string)cities["UK"]; //cast to string
string citiesOfUSA = (string)cities["USA"]; //cast to string

Console.WriteLine(citiesOfUK);
Console.WriteLine(citiesOfUSA);