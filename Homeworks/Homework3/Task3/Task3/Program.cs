void myFunction()
{
    int num;
    int sum = 0;
    int digit;
    Console.WriteLine("Enter at least two numbers:  ");
    bool succes = int.TryParse(Console.ReadLine(), out num);
    if (succes)
    {
        while(num>0)
        {
            digit = num % 10;
            sum += digit;
            num = num / 10;

        }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }
    else
    {
        Console.WriteLine("You must enter a number!");
    }
}

myFunction();