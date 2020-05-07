using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movement : MonoBehaviour
{private Vector3 targetPos;
    //private Vector3 targetPosCam;
    private float speed= 10f;
    //public GameObject cam;
    public bool isFlat = true;
    private Rigidbody rigid;
    private Vector3 tilt;
    private float speed1 = 1.0f;
    private Vector3 rotationDefault;
 
  
    // Start is called before the first frame update

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
          rotationDefault = transform.rotation.eulerAngles;
      
    }
    // Update is called once per frame
    void Update()
    {
         tilt = Input.acceleration;
        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0)*tilt;

       transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (tilt.x > -0.04 && tilt.x < 0.04)
            targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.75f);
        

        else
            targetPos = new Vector3(tilt.x * 8, transform.position.y, transform.position.z + 0.75f);


         Vector3 targetDirection = targetPos - transform.position;
       
        if (targetDirection.x > 0.07 || targetDirection.x < -0.07)
       {
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed1 * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
       
        }

        else if (tilt.x > -0.04 && tilt.x < 0.04)
           transform.eulerAngles = rotationDefault;

    }

}