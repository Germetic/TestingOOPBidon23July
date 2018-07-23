using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapezeShape : Shape {

    [SerializeField]
    protected double _bottomSide;
    [SerializeField]
    protected double _topSide;
    [SerializeField]
    protected double _height;

    public override double GetArea()
    {
        double s = ((_bottomSide * _topSide) / 2) * _height;
        return s;
    }
    public override void Initialize()
    {
        _height = UnityEngine.Random.Range(0, 100f);
        _bottomSide = UnityEngine.Random.Range(0, 100f);
        _topSide = UnityEngine.Random.Range(0, 100f);
        _name = "Trapeze";
    }
    public override string AboutInfo()
    {
        string toString = _name + "| Area = " + GetArea() + "/ Color = " + GetColor() + " Height " + _height;
        return toString;
    }
}
