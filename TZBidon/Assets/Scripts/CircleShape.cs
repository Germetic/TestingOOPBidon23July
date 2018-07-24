using UnityEngine;
using System;

public class CircleShape : Shape {

    [SerializeField]
    private double _radius;

    public override double GetArea()
    {
        double s = Math.PI * (_radius * _radius);
        return s;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public override Shape Initialize()
    {
        base.Initialize();
        _radius = UnityEngine.Random.Range(0, 100f);
        _name = "Circle";
        return this;
    }
    public override string AboutInfo()
    {
        string toString = _name + "| Area = " + GetArea() + "/ Color = " + GetColor() + " Radius " + GetRadius();
        return toString;
    }
}
