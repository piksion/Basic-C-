int[] array = new int[6];
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter integer no.{i + 1}: ");
    string input = Console.ReadLine();
    bool success = int.TryParse(input, out array[i]);
}

foreach(int num in array)
{
    if(num % 2 == 0)
    {
        sum += num;
    }else
    {
        Console.WriteLine("Invalid input!");
    }
}
Console.WriteLine($"The result is: {sum}");

