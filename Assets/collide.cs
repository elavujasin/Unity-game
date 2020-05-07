using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public static bool flag = false;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        flag = true;
 

    }

}
