﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript
{
    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("ToonTile");

        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
    public static void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            if (t.GetComponent<Tile>() == null)
            {
                t.AddComponent<Tile>();
            }
        }
    }
}
