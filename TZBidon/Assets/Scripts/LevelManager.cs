using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public ShapesCreator ShapesCreator;
    public List<Shape> SpawnedShapes;

    private void Start ()
    {
        SpawnedShapes = new List<Shape>();
        int generationTimes = Random.Range(1, 10);
        GenerateRandomShapes(generationTimes);
        ShowSpawnedShapesInfo();
	}

    /// <summary>
    /// Write info about current shape into console
    /// </summary>
    private void ShowSpawnedShapesInfo()
    {
        Debug.Log("<color=orange><b> ________________________</b></color>");
        for (int i = 0; i < SpawnedShapes.Count; i++)
        {           
            Debug.Log(SpawnedShapes[i].AboutInfo() + " \n <color=blue><b> ___ </b></color>");
        }
        Debug.Log("<color=orange><b> ________________________</b></color>");
    }

    /// <summary>
    /// How many shapes will spawned
    /// </summary>
    /// <param name="generationTimes"></param>
    public void GenerateRandomShapes(int generationTimes)
    {
        for (int i = 0; i < generationTimes; i++)
        {
            int currentShapeNumber = UnityEngine.Random.Range(0, ShapesCreator.GetShapesCount()-1);
           
            Shape newshape = ShapesCreator.GetShape((ShapesCreator.ShapeType)currentShapeNumber);
            newshape.Initialize();
            SpawnedShapes.Add(newshape);
        }
    }
}
