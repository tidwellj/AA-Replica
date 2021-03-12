using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && Visible.staTe == 0)
        {
            SpawnPin();
        }
    }
    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
