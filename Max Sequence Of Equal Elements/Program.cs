List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int maxNumber = 0;
int maxSequence = 0;
int currentNumber = 0;
int sequence = 1;

for (int i = 0; i < numbers.Count-1; i++)
{
    currentNumber = numbers[i];
    if (numbers[i] == numbers[i + 1])
    {
        sequence++;
    }
    if (numbers[i]!= numbers[i + 1])
    {
        if(sequence>maxSequence)
        {
            maxSequence = sequence;
            maxNumber =currentNumber ;
        }
    }
}
for (int i = 0; i < maxSequence-1; i++)
{
    Console.Write(maxNumber+ " ");
}
