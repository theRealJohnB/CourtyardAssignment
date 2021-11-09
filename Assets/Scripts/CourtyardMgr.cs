using Assets.Scripts;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtyardMgr : MonoBehaviour
{
    public GameObject BuildingsGO;
    public Buildings buildings;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            buildings = new Buildings();

            // Create the memory map of objects 
            foreach (Transform t in BuildingsGO.transform)
            {
                Building nbuilding = new Building(t);
                buildings.Add(nbuilding);

            }
            Debug.Log("You created the model successfully!");
            
        }
        catch (System.Exception e)
        {
            Debug.Log("You didn't create the model successfully");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
