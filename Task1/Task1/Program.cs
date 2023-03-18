int AgeCalculator(DateTime birthday)
{
    DateTime now = DateTime.Today;
    int age = now.Year - birthday.Year;
    if(now < birthday.AddYears(age))
    {
        age--;
    }
    return age;
}
DateTime birthday = new DateTime(2001, 7, 21);
int age = AgeCalculator(birthday);
Console.WriteLine($"You are {age} years old!");