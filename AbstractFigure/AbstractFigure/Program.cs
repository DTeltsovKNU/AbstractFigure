
using System;

namespace AbstractFigure
{
    abstract class Figure
    {
        public virtual void Perimeter() { }
        public virtual void Area() { }
    }

    class Square : Figure
    {
        private int a;
        public Square(int a)
        {
            this.a = a;
        }
        public override void Area()
        {
            int s = a * a;
            Console.WriteLine("Площадь квадрата = " + s);
        }
        public override void Perimeter()
        {
            int p = a*4;
            Console.WriteLine("Периметр квадрата = " + p);
        }
    }

    class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void Area()
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            Console.WriteLine("Площадь треугольника = " + s);
        }
        public override void Perimeter()
        {
            double p = a + b + c;
            Console.WriteLine("Периметр треугольника = " + p);
        }
    }

    class Circle : Figure
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override void Area()
        {
            double s = Math.PI * Math.Pow(r,2);
            Console.WriteLine("Площадь круга = " + s);
        }
        public override void Perimeter()
        {
            double p = 2 * Math.PI * r;
            Console.WriteLine("Периметр круга = " + p);
        }
    }

    class Rectangle : Figure
    {
        private int a;
        private int b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override void Area()
        {
            int s = a * b;
            Console.WriteLine("Площадь прямоугольника = " + s);
        }
        public override void Perimeter()
        {
            int p = (a * b) * 2;
            Console.WriteLine("Периметр прямоугольника = " + p);
        }
    }

    class Rhomb : Figure
    {
        private int a;
        private int h;
        public Rhomb(int a, int h)
        {
            this.a = a;
            this.h = h;
        }
        public override void Area()
        {
            int s = a * h;
            Console.WriteLine("Площадь ромба = " + s);
        }
        public override void Perimeter()
        {
            int p = a * 4;
            Console.WriteLine("Периметр ромба = " + p);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Rhomb r = new Rhomb(4, 3);
            r.Area();
            r.Perimeter();
            Square s = new Square(6);
            s.Perimeter();
            s.Area();
            Circle c = new Circle(5);
            c.Area();
            c.Perimeter();
            Rectangle rec = new Rectangle(4, 2);
            rec.Perimeter();
            rec.Area();
            Triangle t = new Triangle(3, 4, 5);
            t.Area();
            t.Perimeter();
        }
    }
}
