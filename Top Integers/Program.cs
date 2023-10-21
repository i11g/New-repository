using System.Runtime.InteropServices;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> topIntegers=new List<int>();

for (int i = 0; i < numbers.Count-1; i++)
{
    bool isTopInteger = true;
    for (int j = 1; j < numbers.Count; j++)
    {
        if (numbers[i] <numbers[j])
        {   
            isTopInteger = false;
            numbers.Remove(numbers[i]);
            break;            
        }
        
    }
    if(!isTopInteger)
    {
        i = -1;
    }
   
    
    
}
Console.WriteLine(string.Join(" ",numbers));
