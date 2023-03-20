
namespace Task1.Methods
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        
        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base (name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            Console.WriteLine("That there is no special implementation for area");
        }
        public override void GetPerimiter()
        {
            Console.WriteLine("That there is no special implementation for area");
        }
        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Pos1:{Position[0]}, Pos2: {Position[1]}");
        }
    }
}
