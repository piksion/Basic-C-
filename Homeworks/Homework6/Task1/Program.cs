Queue<int> numbersQueue = new Queue<int>();
bool continute = true;
while (continute)
{
    Console.WriteLine("Enter a number: ");
    int numInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Do you want to continue? Press 'Y' to continue or 'N' to cancel!");
    string userInput = Console.ReadLine().ToUpper();
    numbersQueue.Enqueue(numInput);
    if (userInput == "N")
    {
        Console.Write("Showing numbers in the Queue: \n");
        foreach(int num in  numbersQueue) 
        {
            Console.WriteLine(num + " ");
        }
        
        break;
    }
}