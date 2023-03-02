Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Operation: ");
string operand = Convert.ToString(Console.ReadLine());

if (operand == "+")
{
    int result1 = num1 + num2;
    Console.WriteLine("The result is: " + result1);
}
else if (operand == "-")
{
    int result2 = num1 - num2;
    Console.WriteLine("The result is: " + result2);
}
else if (operand == "*")
{
    int result3 = num1 * num2;
    Console.WriteLine("The result is: " + result3);
}
else if (operand == "/")
{
    int result4 = num1 / num2;
    Console.WriteLine("The result is: " + result4);
}
else
{
    Console.WriteLine("Invalid input!");
}

