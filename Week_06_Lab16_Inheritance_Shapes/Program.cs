using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_Lab16_Inheritance_Shapes
{
    public class Program
    {
        //abstract class Shape
        abstract class Shape 
        { 
            //properties
            public string Name { get; private set; }
            public abstract double Area { get;  }

            //constructor
            public Shape(string name)
            {
                Name = name;
            }
            //string representation
            public override string ToString()
            {

                return $"The shape is a {GetType().Name}. It's name is {Name} and area is {Area}";
            }
        }

        //Square class inherits Shape
        class Square : Shape 
        {
            //properties
            public double Length { get; protected set; }
            public override double Area { get {return Length * Length;}
            }
            //constructor
            public Square(string name, double length) : base(name) 
            { 
                Length = length ;
            }
        }

        //Circle class inherits Square
        class Circle : Square 
        {
            //properties
            public override double Area { get{ return Math.PI * Length * Length;}
        }
            //constructor
            public Circle(string name, double length) : base(name, length)
            { }
        }

        //Rectangle class inherits Shape
        class Rectangle : Shape 
        {
            //properties
        public double Width { get; protected set; } 
        public double Height { get; protected set; }
        public override double Area { get { return Width * Height; } }
            //constructor
        public Rectangle(string name, double height, double width) : base(name)
            {
                Height = height;
                Width = width;
            }
        }

        //Eclipse class inherits Rectangle
        class Ellipse : Rectangle 
        {
            //properties
        public override double Area { get { return Math.PI * Width * Height; } }
            //constructor
        public Ellipse(string name, double height, double width) : base (name, height, width)
            { }
        }

        //Triangle class inherits Rectangle
        class Triangle : Rectangle 
        {
            //properties
        public override double Area { get { return Width * Height * 0.5; } }
            //constructor
        public Triangle(string name, double height, double width) : base(name, height, width) 
            { }
        }

        //Diamond class inherits Rectangle
        class Diamond : Rectangle 
        { 
            //properties
        public override double Area { get { return Width * Height * 0.5; } }
            //constructor
         public Diamond(string name, double height, double width) : base(name, height, width)
            { }
        }

        static void Main(string[] args)
        {
            //Test Harness
            //although Shape is an abstract is can be used as a reference type
            //any child class of Shape is also a Shape
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
            Console.ReadKey();

        }
    }
}
