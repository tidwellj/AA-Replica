using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float speed = 100;

    // Update is called once per frame
    void Update()
    {
     //   Debug.Log(speed + RotatorSpeed.rotatorSpeed);
       
        transform.Rotate(0f, 0f, (speed + RotatorSpeed.rotatorSpeed) * Time.deltaTime);
    }
}
