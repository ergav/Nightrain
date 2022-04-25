using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{

    int height;
    int width;
    float cellSize;

    int[,] gridArray;
    public Grid (int height, int width, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                Debug.Log(x + " " + y);
                Debug.DrawLine(GetWorldposition(x, y), GetWorldposition(x, y+1), Color.white, 100f);
                Debug.DrawLine(GetWorldposition(x, y), GetWorldposition(x + 1, y), Color.white, 100f);

            }
            Debug.DrawLine(GetWorldposition(0, height), GetWorldposition(width, height), Color.white, 100f);
            Debug.DrawLine(GetWorldposition(width, 0), GetWorldposition(width, height), Color.white, 100f);


        }

    }

    Vector3 GetWorldposition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}
