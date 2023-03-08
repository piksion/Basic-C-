Console.WriteLine("Enter some words: ");
string input = Console.ReadLine();
if(input.Length >= 5)
{
    Console.WriteLine(input.Substring(input.Length - 5));
}
else
{
    Console.Write("String is too short!");
}