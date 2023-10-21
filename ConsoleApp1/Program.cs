List <int> firstList=new List<int> ();
List <int> secondList=new List<int> (); 

int num=int.Parse(Console.ReadLine());
bool isNumber = true;
for (int i = 0; i < num; i++)
{   
    List<int> values = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    int firstValue = values[0];
    int secondValue = values[1];
    if(isNumber)
    {
        firstList.Add (firstValue);
        secondList.Add (secondValue);
    }
    else
    {
        firstList.Add(secondValue);
        secondList.Add(firstValue);
    }
    isNumber = !isNumber;
}
Console.WriteLine(string.Join(" ",firstList));
Console.WriteLine(string.Join(" ",secondList));