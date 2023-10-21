List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

List<int> bombsAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int bomb = bombsAndPower[0];
int bombPower = bombsAndPower[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bomb)
    {
        int startIndex = i - bombPower;
        int bombSequence = bombPower + bombPower + 1;
        numbers.RemoveRange(startIndex, bombSequence);
        i = -1;
        if(startIndex<0)
        {
            bombSequence = bombSequence - Math.Abs(startIndex);
            startIndex = 0;
        }
        if (bombSequence+startIndex >numbers.Count )
        {
            bombSequence = numbers.Count-startIndex;
        }
        if(bombSequence <i)
        {
            
        }
    }

    numbers.Sum();
}
Console.WriteLine(string.Join(" ",numbers));
Console.WriteLine(numbers.Sum());

