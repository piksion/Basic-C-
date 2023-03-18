using Task_2;

Console.WriteLine("Enter dog's name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter dog's breed: ");
string breed = Console.ReadLine();

Console.WriteLine("Enter dog's color: ");
string color = Console.ReadLine();

Dog dog = new Dog
{

    Name = name,
    Breed = breed,
    Color = color

};

Console.WriteLine("What do you want the dog to do?");
Console.WriteLine("1: Eat");
Console.WriteLine("2: Play");
Console.WriteLine("3: Chase it's tail");

int input = int.Parse(Console.ReadLine());
switch (input)
{
    case 1:
        dog.Eat();
        break;
    case 2:
        dog.Play(); 
        break;
    case 3:
        dog.ChaseTail();
        break;
    default:
        Console.WriteLine("Invalid choise!");
        break;
}
//if(input = '1')
//{
//    dog.Eat();
//}else if(input = '2')
//{
//    dog.Play();
//}else if( input = '3')   
//{
//    dog.ChaseTail();
//}else
//{
//    Console.WriteLine("Invalid Choice!");
//}
