namespace ShapeHierarchy
{
   public abstract class Shape
   {
       public string Name { get; private set; }
       public abstract double Area { get; }

       public Shape(string name)
       {
           Name = name;
       }

       public override string ToString()
       {
           return $"{Name}: Area = {Area}";
       }
   }

   public class Square : Shape
   {
       public double Length { get; protected set; }

       public Square(string name, double length) : base(name)
       {
           Length = length;
       }

       public override double Area => Length * Length;
   }

   public class Circle : Square
   {
       public Circle(string name, double radius) : base(name, radius) { }

       public override double Area => Math.PI * Length * Length;
   }

   public class Rectangle : Shape
   {
       public double Width { get; protected set; }
       public double Height { get; protected set; }

       public Rectangle(string name, double height, double width) : base(name)
       {
           Width = width;
           Height = height;
       }

       public override double Area => Width * Height;
   }

   public class Ellipse : Rectangle
   {
       public Ellipse(string name, double height, double width) : base(name, height, width) { }

       public override double Area => Math.PI * Width * Height;
   }

   public class Triangle : Rectangle
   {
       public Triangle(string name, double height, double width) : base(name, height, width) { }

       public override double Area => Width * Height * 0.5;
   }

   public class Diamond : Rectangle
   {
       public Diamond(string name, double height, double width) : base(name, height, width) { }

       public override double Area => Width * Height * 0.5;
   }

   class Program
   {
       static void Main(string[] args)
       {
           List<Shape> shapes = new List<Shape>();

           shapes.Add(new Square("s1", 2));
           shapes.Add(new Rectangle("r1", 2, 3));
           shapes.Add(new Circle("c1", 2));
           shapes.Add(new Triangle("t1", 4, 6));
           shapes.Add(new Ellipse("e1", 2, 3));
           shapes.Add(new Diamond("d1", 2, 3));
           shapes.Add(new Square("s2", 5));
           shapes.Add(new Rectangle("r2", 5, 4));
           shapes.Add(new Circle("c2", 1));
           shapes.Add(new Triangle("t2", 7, 8));

           foreach (var s in shapes)
           {
               Console.WriteLine(s);
           }
       }
   }
}
