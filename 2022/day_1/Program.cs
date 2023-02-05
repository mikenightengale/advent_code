string[] lines = File.ReadAllLines("input.txt");
List<int> currentElfCalories = new();
List<int> elfCalories= new();

foreach (string line in lines)
{
    if (!string.IsNullOrEmpty(line))
    {
        currentElfCalories.Add(int.Parse(line));
        
        if (line != lines.Last())
        {
            continue;
        }
    }

    elfCalories.Add(currentElfCalories.Sum());
    currentElfCalories.Clear();
}

var topElvesCalories = elfCalories.Order().OrderDescending().Take(3);
Console.WriteLine($"PART ONE: Elf with most calories: {topElvesCalories.FirstOrDefault()}");
Console.WriteLine($"PART TWO: Total calories of top three elves: {topElvesCalories.Sum()}");