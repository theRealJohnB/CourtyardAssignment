using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building 
{
    public List<Wall> walls;
    public string name;
    

    public Building(Transform _t)
    {
        walls = new List<Wall>();

        foreach (Transform t in _t.transform)
        {
            Wall nwall = new Wall
            {
                transform = t,
                name = t.name,
                tag = t.tag,
                isDoor = t.name == "Door"
            };
            walls.Add(nwall);
        }
    }
}
