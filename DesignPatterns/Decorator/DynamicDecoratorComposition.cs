using System;

namespace DesignPatterns.Decorator
{
    public interface IShape
    {
        string AsString();
    }

    public class Circle : IShape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public string AsString() => $"A circle with radius {_radius}";

        public void Resize(float factor)
        {
            _radius *= factor;
        }
    }

    public class Square : IShape
    {

        private readonly float _side;

        public Square(float side)
        {
            _side = side;
        }

        public string AsString() => $"A square with side {_side}";
    }

    // Dynamic decorator done at runtime
    public class ColoredShape : IShape
    {
        private readonly IShape _shape;
        private readonly string _color;

        public ColoredShape(IShape shape, string color)
        {
            _shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
            _color = color ?? throw new ArgumentNullException(paramName: nameof(color));
        }

        public string AsString()=> $"{_shape.AsString()} has the color {_color}";
    }

    // Dynamic decorator done at runtime
    public class TransparentShape : IShape
    {
        private readonly IShape _shape;
        private readonly float _transparency;

        public TransparentShape(IShape shape, float transparency)
        {
            _shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
            _transparency = transparency;
        }

        public string AsString() => $"{_shape.AsString()} has {_transparency * 100.0}% transparency";
    }
}