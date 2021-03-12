using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preserve : MonoBehaviour
{

    public static Preserve instance;
    //public static string keep;
    // Start is called before the first frame update
    void Awake()
    {

       // keep = GetName.userIDs;

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
