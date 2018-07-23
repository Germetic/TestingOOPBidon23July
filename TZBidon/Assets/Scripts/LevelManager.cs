using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public List<Shape> AllShapes;
    public List<Shape> SpawnedShapes;

    void Start ()
    {
        SpawnedShapes = new List<Shape>();
        int generationTimes = UnityEngine.Random.Range(1, 10);
        GenerateRandomShapes(generationTimes);
        ShowSpawnedShapesInfo();
	}

    private void ShowSpawnedShapesInfo()
    {
        for (int i = 0; i < SpawnedShapes.Count; i++)
        {
            
            Debug.Log(SpawnedShapes[i].AboutInfo() + " \n <color=blue><b> ___ </b></color>");
        }
    }

    /// <summary>
    /// How many shapes will spawned
    /// </summary>
    /// <param name="generationTimes"></param>
    public void GenerateRandomShapes(int generationTimes)
    {
        for (int i = 0; i < generationTimes; i++)
        {
            int currentShapeNumber = UnityEngine.Random.Range(0, AllShapes.Count - 1);
            Shape spawnedSHape = Instantiate(AllShapes[currentShapeNumber], transform.position, Quaternion.identity);
            SpawnedShapes.Add(spawnedSHape);
            spawnedSHape.Initialize();
        }
    }
}
