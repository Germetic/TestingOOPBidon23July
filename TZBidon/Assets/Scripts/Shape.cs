using UnityEngine;

public abstract class Shape
{

    [SerializeField]
    protected Color _color;
    [SerializeField]
    protected double _area;

    protected string _name;

    public Shape(Color color, double area = 0, string name = null)
    {
        _color = color;
        _area = area;
        _name = name;
    }
    public Shape(double area = 0, string name = null)
    {
        _color = Color.white;
        _area = area;
        _name = name;
    }

    /// <summary>
    /// Returns shape S 
    /// </summary>
    /// <returns></returns>
    public abstract double GetArea();
    public Color GetColor()
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
    public virtual Shape Initialize()
    {
        _color = GetRandomColor();
        return this;
    }
    protected virtual Color GetRandomColor()
    {
        byte red = (byte)UnityEngine.Random.Range(0, 255);
        byte green = (byte)UnityEngine.Random.Range(0, 255);
        byte blue = (byte)UnityEngine.Random.Range(0, 255);

        return new Color(red, green, blue);
    }
}
