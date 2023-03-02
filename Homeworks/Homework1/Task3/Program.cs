Console.WriteLine("Input the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second numbeR: ");
int num2 = int.Parse(Console.ReadLine());

int swap = num1;
num1 = num2;
num2 = swap;
Console.WriteLine("After swapping: ");
Console.WriteLine("First number: {0}", num1);
Console.WriteLine("Second number: {0}", num2);