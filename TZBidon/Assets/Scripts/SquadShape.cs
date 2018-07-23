using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadShape : Shape {

    [SerializeField]
    private double _sideLength;

    public override double GetArea()
    {
        double s = _sideLength * _sideLength;
        return s;
    }
    public double GetSideLength()
    {
        return _sideLength;
    }
    public override void Initialize()
    {
        _sideLength = UnityEngine.Random.Range(0, 100f);
        _name = "Squad";
    }
    public override string AboutInfo()
    {
        string toString = _name + "| Area = " + GetArea() + "/ Color = " + GetColor() + " SideLength " + _sideLength;
        return toString;
    }
}
