

/*List<int> primeNumber = new List<int>();
primeNumber.Add(1);
primeNumber.Add(2);

var city = new List<string>()
{
    "Dhaka",
    "Khulna",
    "Kushtia"
};

foreach (string city1 in city)
{
    Console.WriteLine(city1);
}*/

using List;
using System.Net.NetworkInformation;
//List of Custom Objects
List<Person> people = new List<Person>
{
    new Person("Alice",30),
    new Person("Nimur",32)
};
foreach(Person n in people)
{
    Console.WriteLine($"name: {n.Name}");
}

//Using LINQ with List
List<int> number1 = new List<int> {1,2,3,4,5,6,7,8,9,11 };

var evenNumber=number1.Where(n=>n%2 == 0).ToList();
Console.WriteLine("Even Number:");
foreach(int number in evenNumber)
{
    Console.WriteLine(number);
}
//Converting List to Array and Vice Versa