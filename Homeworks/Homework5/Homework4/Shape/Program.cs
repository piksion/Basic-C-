using Task1.Methods;

int[] position = { 0, 0 };
Shape shape = new Shape("Shape", "White", position);
shape.GetArea();
shape.GetPerimiter();
shape.Move();

Rectangle rectangle = new Rectangle("Rectangle", "Blue", position,10, 20);
rectangle.GetArea();
rectangle.GetPerimiter();
rectangle.Move();

Circle circle = new Circle("Circle", "Yellow", position,40);
circle.GetArea();
circle.GetPerimiter();
circle.Move();
