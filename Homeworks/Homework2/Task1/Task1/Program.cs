int[] array = new int[6];
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter integer no.{i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
}

foreach(int num in array)
{
    if(num % 2 == 0)
    {
        sum += num;
    }
}
Console.WriteLine($"The result is: {sum}");

