using System.Diagnostics.CodeAnalysis;

List <int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int sum = 0;


while (numbers.Count > 1)
{
    List<int> condensed = new List<int>();

    for (int i = 0; i < numbers.Count - 1; i++)

    {
       sum =(numbers[i] + numbers[i + 1]);
       condensed.Add(sum);
                  
    }
    numbers = condensed;
}

Console.WriteLine(string.Join(" ", numbers));
