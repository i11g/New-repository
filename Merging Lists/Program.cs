using System.ComponentModel.DataAnnotations;

List <int> numbers1=Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
List <int> numbers2=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int maxLength =Math.Max(numbers1.Count, numbers2.Count);

List<int> combined=new List<int>();


for (int i = 0; i < maxLength; i++)
{
    if(i<numbers1.Count)
    {
      combined.Add(numbers1[i]);
    }
    

    if (i < numbers2.Count)
    {
        combined.Add(numbers2[i]);
    }
    
}
Console.WriteLine(string.Join(" ", combined));