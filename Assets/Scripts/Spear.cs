using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    SpriteRenderer sprite2;

    
    // Update is called once per frame
    void Update()
    {
        if(Pin.check == 1)
        {
            sprite2.color = new Color(1, 0, 0, 1);

        }
    }
}
