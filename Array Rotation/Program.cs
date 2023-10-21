List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int num=int.Parse(Console.ReadLine());

int temp = 0;
while (num > 0)
{

    for (int i = 0; i < numbers1.Count-1; i++)
    {

        temp = numbers1[i];
        numbers1[i] = numbers1[i+1];
        numbers1[i + 1] = temp;
    }
    num--;
}
Console.WriteLine(string.Join(" ", numbers1));