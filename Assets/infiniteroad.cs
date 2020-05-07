using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteroad : MonoBehaviour
{ 
    public GameObject plane;
    //Transform[] ts = plane.GetComponentsInChildren(Transform);
  

    void OnTriggerEnter(Collider other)
    {   
         
            plane.transform.position = new Vector3(plane.transform.position.x, plane.transform.position.y, plane.transform.position.z + 100f);
        for (int i = 0; i < 17; i++)
            plane.transform.GetChild(i).gameObject.SetActive(true);
       

        
    }
}

    
