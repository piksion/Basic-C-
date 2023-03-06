string[] G1 = new string[] { "Petar", "Jovana", "Andrijana", "Ivan", "Sergej" };
string[] G2 = new string[] { "Rakida", "Razmena", "Borka", "Zorka", "Menka" };

Console.Write("Enter student group(there are 1 and 2): ");
string firstInput = Console.ReadLine();
int input;
bool success = int.TryParse(firstInput, out input);

if (input == 1)
{
    Console.WriteLine("The students in G1 are: ");
    foreach (string student in G1)
    {
        Console.WriteLine(student);
    }
}
else if (input == 2)
{
    Console.WriteLine("The students in G2 are: ");
    foreach (string student in G2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input!");
}
