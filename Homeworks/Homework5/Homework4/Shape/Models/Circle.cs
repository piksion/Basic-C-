

namespace Task1.Methods
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        
        public Circle(string name, string color, int[] position, int radius) : base(name,color,position)
        {
            Radius = radius;
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
