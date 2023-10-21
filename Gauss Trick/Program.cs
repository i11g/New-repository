List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int sum = 0;
List<int> sequence = new List<int>();

for (int i = 0; i <numbers.Count/2 ; i++)
{
    sum = numbers[i] + numbers[numbers.Count - 1 - i];
    sequence.Add(sum);
    

}
if (numbers.Count % 2 != 0)
{
    sequence.Add(numbers.Count / 2);
}
Console.WriteLine(string.Join(" ", sequence));