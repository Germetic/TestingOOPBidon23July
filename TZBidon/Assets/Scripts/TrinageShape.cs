﻿using System;
using UnityEngine;


public class TrinageShape : Shape
{   
    [SerializeField]
    private double _height;
    [SerializeField]
    private double _aSide;
    [SerializeField]
    private double _bSide;
    [SerializeField]
    private double _cSide;

    public override double GetArea()
    {
        double p = GetPerimeter();
        double s = System.Math.Sqrt(p * (p-_aSide) * (p-_bSide) * (p-_cSide));
        return s;
    }

    private double GetPerimeter()
    {
        double p = (_aSide + _bSide + _cSide) / 2;
        return p;
    }

    public double GetHypotenuse()
    {
        return Math.Pow(_aSide, 2) * Math.Pow(_bSide,2);
    }

    public override Shape Initialize()
    {
        base.Initialize();
        _height = UnityEngine.Random.Range(0, 15f);
        _aSide = UnityEngine.Random.Range(0, 15f);
        _bSide = UnityEngine.Random.Range(0, 15f);
        _cSide = UnityEngine.Random.Range(0, 15f);
        _name = "Trinage";
        return this;
    }

    public override string AboutInfo()
    {
        string toString = _name + "| Area = " + GetArea() + "/ Color = " + GetColor() + " Height " + _height + " Hypotenuse " + GetHypotenuse();
        return toString;
    }
}
