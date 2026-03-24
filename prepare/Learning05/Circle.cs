using System;

class Circle : Shape
{
    double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = 3.1415926535;
        return pi * _radius * _radius;
    }
}