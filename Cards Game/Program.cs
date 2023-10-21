List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

while (numbers1.Count > 0 && numbers2.Count > 0)
{
	bool isLost = false;
	for (int i = 0; i < numbers1.Count; i++)
	{
		if (numbers1[i] > numbers2[i])
		{
			numbers1.Add(numbers1[i]);
			numbers1.Add(numbers2[i]);
			numbers1.Remove(numbers1[i]);
			numbers2.Remove(numbers2[i]);
			i = -1;
			if(numbers2.Count==0)
			{
				isLost=true;
				break;
			}

		}
		else if (numbers1[i] < numbers2[i])
		{
			numbers2.Add(numbers2[i]);
			numbers2.Add(numbers1[i]);
			numbers2.Remove(numbers2[i]);
			numbers1.Remove(numbers1[i]);
			i = -1;
		}


		else if (numbers1[i] == numbers2[i])
		{

			numbers1.Remove(numbers1[i]);
			numbers2.Remove(numbers1[i]);
		}
	}
	if(isLost)
	{
		break;
	}

}

if (numbers1.Count > numbers2.Count)
{
    Console.WriteLine($"First player wins! Sum: {numbers1.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {numbers2.Sum()}");
}
