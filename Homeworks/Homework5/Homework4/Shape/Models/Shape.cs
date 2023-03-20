
namespace Task1.Methods
{
    public class Shape
    {
       private string _name;
       private string _color;
       private int[] Position { get; set; }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; 
            if(string.IsNullOrEmpty(_name))
                {
                    Console.WriteLine("Invalid input");
                }else
                {
                    Console.WriteLine($"The name is: {_name}");
                }
            }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; 
                if(string.IsNullOrEmpty(_color))
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    Console.WriteLine($"The color is: {_color}");
                }
            }
        }

        public virtual void GetArea()
    {
        Console.WriteLine("That there is no special implementation for area");
    }
    public virtual void GetPerimiter()
    {
        Console.WriteLine("That there is no special implementation for area");
    }
    public virtual void Move()
    {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Pos1:{Position[0]}, Pos2: {Position[1]}");
    }
 }

