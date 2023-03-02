Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int num2  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int num3  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the fourth number: ");
int num4 = Convert.ToInt32(Console.ReadLine());

int result = (num1 + num2 + num3 + num4) / 4;
//Console.WriteLine("The avarage of ", num1, ",", num2, ",", num3, ",", num4, "is: ", result);
Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ", num1, num2, num3, num4, result);