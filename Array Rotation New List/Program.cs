List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int currentNumber = numbers1[0];
    numbers1.Add(currentNumber);
    numbers1.Remove(numbers1[0]);
}
Console.WriteLine(string.Join(" ", numbers1));