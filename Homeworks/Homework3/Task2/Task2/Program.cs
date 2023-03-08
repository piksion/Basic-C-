Console.WriteLine("Enter a sentence: ");
string input = Console.ReadLine();
string[] words = input.Split(' ');

foreach(string word in words)
{
    Console.WriteLine(word);
}