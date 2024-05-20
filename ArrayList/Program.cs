using System.Collections;

ArrayList arrayList = new ArrayList();

ArrayList array = new ArrayList()
{
    200,
    "nimur",
    "hasan",8.8
};
Console.WriteLine(array.Contains(200));
int id = (int)array[0];
Console.WriteLine(id);
foreach (var item in array)
{
    Console.WriteLine(item);
}