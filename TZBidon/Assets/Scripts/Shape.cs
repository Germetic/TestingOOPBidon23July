using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Shape : MonoBehaviour {

    [SerializeField]
    private Color32 _color;
    [SerializeField]
    private double _area;

    protected string _name;

    /// <summary>
    /// Returns shape S 
    /// </summary>
    /// <returns></returns>
    public abstract double GetArea();
    public Color32 GetColor()
    {
        return _color;
    }
    /// <summary>
    /// Draw shape sprite on Scene
    /// </summary>
    /// <returns></returns>
    public virtual void DrawShape()
    {
        Debug.Log("<color=orange><b> I DRAW SHAPE </b></color>" + this.ToString());
    }

    public virtual string AboutInfo()
    {
        string toString = "Area = " + GetArea() + "/ Color = " + GetColor();
        return toString;
    }
    /// <summary>
    /// Filling all field with random information
    /// </summary>
    public abstract void Initialize();
}
