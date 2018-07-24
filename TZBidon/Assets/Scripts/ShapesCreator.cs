using System;
using UnityEngine;

public class ShapesCreator : MonoBehaviour
{
    public enum ShapeType
    {
        Trinage,
        Squad,
        Circle,
        Trapeze
    }
    /// <summary>
    /// Returns new uniqe shape by type
    /// </summary>
    /// <param name="shapeType"></param>
    /// <returns></returns>
    public Shape GetShape(ShapeType shapeType)
    {
        switch (shapeType)
        {
            case ShapeType.Trinage:
                return new TrinageShape();

            case ShapeType.Squad:
                return new SquadShape();

            case ShapeType.Circle:
                return new CircleShape();

            case ShapeType.Trapeze:
                return new TrapezeShape();
            default:
                break;
        }
        Debug.LogError("Wrong shape");
        return null;
    }
    /// <summary>
    /// Shapes differences count
    /// </summary>
    /// <returns></returns>
    public int GetShapesCount()
    {
        return Enum.GetValues(typeof(ShapeType)).Length;
    }
}
